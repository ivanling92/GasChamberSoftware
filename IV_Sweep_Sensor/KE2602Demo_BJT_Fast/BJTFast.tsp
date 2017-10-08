--[[
BJTFast():

This program performs a sequence of 
standard transistor tests with values setup 
for a 2N3904 part.

This script creates the following functions that perform standard tests 
for a Bipolar Junction Transistor:

1) Setup
2) VCEO
3) VCEsat (Performs VCEsat and VBEsat tests simultaneously)
4) HFE/Beta Gain test

Required equipment:

(1) Keithley 2602 System Sourcemeter(c)
(1) Keithley 8101-04-TRX Test Fixture
(2) Keithley 2600-DEMO-TRX cables 

Rev1: JAC 4.7.2005
Rev2: Add Print Data option
      JAC 4.22.2005
]]--

------------------ Keithley TSP Function ------------------
function BJTFast(num,return_data)

bin_fail_VCEO = 0
bin_fail_VCEsat = 0
bin_fail_VBEsat = 0
bin_fail_HFE = 0
bin_all_pass = 0

--clear the front panel display and prompt for input parameters if missing
display.clear()

if num == nil then 
	num = display.prompt("0000"," Parts","Enter number of parts to test",50,1,9999)
end --end if


    function setup() 
--Sets up instrument

      collector = smua
      base = smub
      d = 0.0005

      i = 1
      j = 1
      LabelCount = 4
      good_parts = 0

      NPLC2 = 0.05
      NPLC = 0.001

      VCEO_data = {}
      VCEsat_data = {}
      VBEsat_data = {}
      BETA1_data = {}

      Label = {"**VCEO**", "**VCEsat**", "**VBEsat**", "**BETA1**"}

  
      AZERO = smua.AUTOZERO_OFF
      --AZERO = smua.AUTOZERO_AUTO
  
      digio.writeport(0) -- Set All Digital I/O lines lo
      display.clear() --Clear 2602 display
   
      base.reset() --Reset base
      collector.reset() --Reset collector
  
      base.source.func = base.OUTPUT_DCVOLTS
      base.measure.autozero = base.AUTOZERO_AUTO
      base.measure.nplc = NPLC
      base.measure.v()
      base.measure.i()
      base.measure.autozero = AZERO
      base.measure.autorangei = base.AUTORANGE_OFF
      base.measure.autorangev = base.AUTORANGE_OFF
      base.source.autorangei = base.AUTORANGE_OFF
      base.source.autorangev = base.AUTORANGE_OFF
   
      base.source.rangei = 0.01 --smu current range
      base.source.levelv = 0 --smu source value
      base.source.output = base.OUTPUT_ON
  

      collector.source.func = collector.OUTPUT_DCVOLTS
      collector.measure.autozero = collector.AUTOZERO_AUTO
      collector.measure.nplc = NPLC
      collector.measure.v()
      collector.measure.i()
      collector.measure.autozero = AZERO
      collector.measure.autorangei = collector.AUTORANGE_OFF
      collector.measure.autorangev = collector.AUTORANGE_OFF
      collector.source.autorangei = collector.AUTORANGE_OFF
      collector.source.autorangev = collector.AUTORANGE_OFF
    
      collector.source.rangev = 40 --smu voltage range
      collector.source.levelv = 0 --smu source value   
      collector.source.output = collector.OUTPUT_ON 
    end 

    function VCEO(i) 
--Source current on collector, open base, and 
--measure voltage on the collector/emitter
   
      local VCEOlimit = 40
 
      collector.measure.nplc = NPLC
      base.measure.nplc = NPLC

      base.source.func = base.OUTPUT_DCAMPS
      base.source.rangev = 40
      base.source.limitv = 40
      base.source.leveli = 0 --smua source value
      base.source.rangei = 100E-9 --smua current range
      base.measure.rangev = 40
      delay(d) --Delay   
   
      collector.source.func = collector.OUTPUT_DCAMPS --SMU to source current 
      collector.source.rangev = 40
      collector.source.rangei = 0.01
      collector.source.leveli = 0.01 --Set Source level
      collector.source.limitv = 40
      collector.measure.rangev = 40
      delay(d) --Delay
   
      VCEO_data[i] = collector.measure.v()   --Measure V
  
      --End of SDM cycle 
   
      if (VCEO_data[i] > 30) then --Evaluate Pass/Fail criterion
        Pass = 1 --Pass is True
      else
        Pass = 0 --Reinitialize Pass
        fail_VCEO = 1
      end --end if
   
--Write Pass/Fail         
      writeHandler(Pass)
      --End of Decision Time
   
    end --end function VCEO()


    function HFE1(i)
--Performs a binary search for the target Gain/Beta/HFE value.
   
	  local k --binary search loop count variable
      local VCESource = 1 --VCEsource value
      local HIGHIb = 10e-7 --Start Ib high limit
      local LOWIb = 1e-9 --Start Ib lo limit
      local HFE1limit = 40 --HFE limit
      local TARGETIc = 100e-6 --Target Ic for binary search

      collector.measure.nplc = NPLC2
      base.measure.nplc = NPLC2

      collector.source.func = collector.OUTPUT_DCVOLTS
      collector.source.limiti = (5 * TARGETIc)
      collector.source.rangev = 6
      collector.measure.rangei = 10e-3

      base.source.func = base.OUTPUT_DCAMPS
      base.measure.rangei = 100e-6
      base.source.limiti = HIGHIb
      base.source.rangev = 6
      base.measure.rangev = 6
      base.source.limitv = 6
 
--Start test 
      collector.source.levelv = VCESource
      base.source.leveli = 0
      collector.source.output = collector.OUTPUT_ON --open relay (open base)
      delay(0.001) --Delay
    
--Search for the right base current
      k = 0
    
      repeat 
        k = k + 1
        Ib = ((HIGHIb-LOWIb)/2) + LOWIb
        base.source.leveli = Ib
        delay(0.001)
        IcMeas = collector.measure.i()
        
        if (TARGETIc < IcMeas) then
          HIGHIb = Ib
        else
          LOWIb = Ib
        end --end if
       until ((math.abs(IcMeas - TARGETIc) < (0.05*TARGETIc))or(k>10))
 
 --iteration limit reached  
       if (k>10) then
       end --end if
   
       BETA1_data[i] = IcMeas/Ib
      
       if (BETA1_data[i] > HFE1limit) then --Evaluate Pass/Fail criterion
         Pass = 1 --Pass is True
       else
         Pass = 0
         fail_HFE = 1 
       end --end if

--Write Pass/Fail          
       writeHandler(Pass)
   
    end --end function HFE1()


    function VCEsat(i)
      sourceCollector = 10E-3 
      limitVCEsat = 0.2

      sourceBase = 1E-3
      limitVBEsat = 1.1
  
      collector.measure.rangev = 1
      collector.source.rangei = sourceCollector
      collector.source.leveli = sourceCollector
 
      base.measure.rangev = 1
      base.source.rangei = sourceBase
      base.source.leveli = sourceBase
	  delay(0.001)
      VCEsat_data[i] = collector.measure.v()

      VBEsat_data[i] = base.measure.v()

      if (VCEsat_data[i] < limitVCEsat) then --Evaluate Pass/Fail criterion
        Pass = 1 --Pass is True
      else
        Pass = 0
        fail_VCEsat = 1
      end --end if
     
      writeHandler(Pass)
   
      if (VBEsat_data[i] < limitVBEsat) then --Evaluate Pass/Fail criterion
        Pass = 1 --Pass is True
      else
        Pass = 0
        fail_VBEsat = 1
      end --end if

--Write Pass/Fail        
      writeHandler(Pass)
   
    end --end function VCEsat()


    function writeHandler(Pass)
  
      if (Pass == 1) then
        digio.writebit(2,1) --Set bit 2 Hi, DUT pass
        
      else
        digio.writebit(8,1) --Set bit 8 Hi, DUT Fail
      end

      delay(d)
      digio.writeport(0) --Reset Digital I/O
    
    end --end function Writehandler()


----------***** Start Test *****----------

    timer.reset()
    setup()
    setup_time = timer.measure.t()

    timer.reset()

    display.settext("Test In Progress")
    display.setcursor(2,1)
    display.settext("Testing "..num.." parts")

    for i = 1,num do
      
      fail_VCEO = 0
      fail_VCEsat = 0
      fail_VBEsat = 0
      fail_HFE = 0

      VCEO(i)
      VCEsat(i)
      HFE1(i)

-- Bin
      if fail_VCEO == 1 then
        bin_fail_VCEO = bin_fail_VCEO + 1
        part_status = " BAD"
      elseif fail_VCEsat == 1 then
        bin_fail_VCEsat = bin_fail_VCEsat + 1
        part_status = " BAD"
      elseif fail_VBEsat == 1 then
        bin_fail_VBEsat = bin_fail_VBEsat + 1
        part_status = " BAD"
      elseif fail_HFE == 1 then
         bin_fail_HFE = bin_fail_VBEsat + 1
         part_status = " BAD"
      else
         bin_all_pass = bin_all_pass + 1
         part_status = " GOOD"
      end --end if

    end --end Main for loop 
    
    test_time = timer.measure.t()/num

--Return instrument to idle state
    base.source.func = base.OUTPUT_DCVOLTS
    base.source.levelv = 0

    collector.source.func = collector.OUTPUT_DCVOLTS
    collector.source.levelv = 0

    base.measure.autozero = smua.AUTOZERO_AUTO
    base.measure.nplc = NPLC
    base.measure.v()
    base.measure.i()

    collector.measure.autozero = smua.AUTOZERO_AUTO
    collector.measure.nplc = NPLC
    collector.measure.v()
    collector.measure.i()

    collector.source.output = collector.OUTPUT_OFF
    base.source.output = base.OUTPUT_OFF

    -- Show Stats
    throughput = 1/test_time
    Percent = good_parts/(num*LabelCount)*100

    display.clear()
    display.settext("Part Status:"..part_status)
    display.setcursor(2,1)
    display.settext("Bin Counts:"..bin_fail_VCEO.." "..bin_fail_VCEsat.." "..bin_fail_VBEsat.." "..bin_fail_HFE.." "..bin_all_pass)
    delay(3)


    display.clear()
    throughput = 1/test_time
    display.settext("Parts per sec:"..string.format("%d",throughput))
    delay(3)

    display.screen = 2
    
    
    function Print_data()
      
      for j = 1,LabelCount do
        print(Label[j])
  
        for i = 1,num do
    
          if j == 1 then
            print(VCEO_data[i])  
          elseif j == 2 then    
            print(VCEsat_data[i])  
          elseif j == 3 then    
            print(VBEsat_data[i])  
          elseif j == 4 then    
            print(BETA1_data[i])  
          end --end if 
        end --end for loop
        print()
      end --end for loop
    end --end function Print_data1()

	if return_data == "yes" then
       Print_data()
    end --if
    
--Print_data1()

end --end function BJTFast()
  
BJTFast(nil,'yes')  
display.loadmenu.add("BJTTest_Fast","BJTFast(nil,'no')")

