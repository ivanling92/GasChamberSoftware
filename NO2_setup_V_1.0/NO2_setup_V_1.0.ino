/***************************************************************************
  This is a library for the BME280 humidity, temperature & pressure sensor

  Designed specifically to work with the Adafruit BME280 Breakout
  ----> http://www.adafruit.com/products/2650

  These sensors use I2C or SPI to communicate, 2 or 4 pins are required
  to interface. The device's I2C address is either 0x76 or 0x77.

  Adafruit invests time and resources providing this open source code,
  please support Adafruit andopen-source hardware by purchasing products
  from Adafruit!

  Written by Limor Fried & Kevin Townsend for Adafruit Industries.
  BSD license, all text above must be included in any redistribution
 ***************************************************************************/

#include <Wire.h>
#include <SPI.h>
#include <Adafruit_Sensor.h>
#include <Adafruit_BME280.h>

#define BME_SCK 13
#define BME_MISO 12
#define BME_MOSI 11
#define BME_CS 10

#define SEALEVELPRESSURE_HPA (1013.25)

Adafruit_BME280 bme; // I2C
//Adafruit_BME280 bme(BME_CS); // hardware SPI
//Adafruit_BME280 bme(BME_CS, BME_MOSI, BME_MISO, BME_SCK); // software SPI
String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;
boolean LED_ON = false;



unsigned long delayTime;

void setup() {
    Serial.begin(9600);
    //Serial.println(F("BME280 test"));
    pinMode(3, OUTPUT);
    inputString.reserve(200);
    bool status;
    // default settings
    status = bme.begin();
    if (!status) {
        Serial.println("Error!");
        while (1);
    }
}


void loop() { 
    if (stringComplete) {
      if(inputString == "UV_ON\n"){
        LED_ON = true;
        analogWrite(3, 180);
      }
      else if(inputString == "UV_OFF\n"){
        LED_ON = false;
        analogWrite(3, 0);
      }
      else if(inputString == "STAT\n"){
        printValues();
      }
    inputString = "";
    stringComplete = false;
  }
    delay(delayTime);
}


void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}



void printValues() {    
    Serial.print(bme.readPressure() / 100.0F);
    Serial.print(",");
    Serial.print(bme.readTemperature());
    Serial.print(",");
    Serial.print(bme.readHumidity());
    Serial.print(",");
    Serial.println(LED_ON);
}
