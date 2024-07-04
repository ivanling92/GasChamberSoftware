# Arduino Set Up
The software reads from Arduino serial in the following order:
NO2, CO, NH3, H2, Temp, Humidity, Pressure, Ambient_temp, heater_status

Every data is in float, and separated by "," no space in between

e.g. 

20.3,24,34,12,4.5,2.3  .... etc

All the gas parameters are in PPM, pressure in hPa, temp in C and humidity in %rh

# Hardware

This software is written for Grove Multichannel Gas sensor and BMP085

Here's an example code, to show how to structure your arduino code:

#include <Wire.h>
#include "MutichannelGasSensor.h"
#include <SPI.h>
#include <Adafruit_Sensor.h>
#include <Adafruit_BME280.h>


#define BME_SCK 13
#define BME_MISO 12
#define BME_MOSI 11
#define BME_CS 10
 
#define SEALEVELPRESSURE_HPA (1013.25)


Adafruit_BME280 bme;
unsigned long delayTime;

void setup() {
    //code for the Gas Sensor
    Serial.begin(115200);  // start serial for output
    while(!Serial); 
    gas.begin(0x04);//the default I2C address of the slave is 0x04
    gas.powerOn();

    //Code for the THP sensor
    unsigned status;
    status = bme.begin(); 
    if (!status) {
        Serial.println("Could not find a valid BME280 sensor, check wiring, address, sensor ID!");
        Serial.print("SensorID was: 0x"); Serial.println(bme.sensorID(),16);
        Serial.print("        ID of 0xFF probably means a bad address, a BMP 180 or BMP 085\n");
        Serial.print("   ID of 0x56-0x58 represents a BMP 280,\n");
        Serial.print("        ID of 0x60 represents a BME 280.\n");
        Serial.print("        ID of 0x61 represents a BME 680.\n");
        while (1) delay(10);
    }
    delayTime = 25;

}

void loop() {
  float c;

    c = gas.measure_NO2();
    if(c>=0) Serial.print(c);
    else Serial.print("invalid");
    Serial.print(",");
    c = gas.measure_CO();
    if(c>=0) Serial.print(c);
    else Serial.print("invalid");
    Serial.print(",");

    ///.... Do the same for all gases
    
    Serial.print(bme.readTemperature());
    Serial.print(",");
    Serial.print(bme.readPressure() / 100.0F);
    Serial.print(",");
    Serial.println(bme.readHumidity());
    delay(25);

}


