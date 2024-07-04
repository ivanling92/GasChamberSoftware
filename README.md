The software reads from Arduino serial in the following order:
NO2, CO, NH3, H2, Temp, Humidity, Pressure, Ambient_temp, heater_status

Every data is in float, and separated by "," no space in between

e.g. 

20.3,24,34,12,4.5,2.3  .... etc



All the gas parameters are in PPM, pressure in hPa, temp in C and humidity in %rh
