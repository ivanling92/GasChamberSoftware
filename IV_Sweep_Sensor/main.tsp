function start(vstart,vend,vint)	
	--beeper.beep(1,1503)
	smua.reset()
	smua.source.output = 1
	ivstr = ""
	for v = vstart, vend, vint do
		smua.source.levelv = v
		ids = smua.measure.i()
		r = v/ids
		ivstr = ivstr..string.format("%g,%g;",v,ids)
		if v < 1 then
			r_ave = r
		else
			r_ave = (r_ave+r)/2
		end
	end
	print(ivstr)
	print(string.format("%f",r_ave))
	
	--if reading < 10 then print("pass")end
	display.clear()
	display.setcursor (1,1)
	display.settext ("IV Measure")
	smua.source.output = 0
end--function