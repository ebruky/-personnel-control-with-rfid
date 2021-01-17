#include <SPI.h>                          
#include <MFRC522.h>      
#include <Wire.h>




int RST_PIN = 9;                          
int SS_PIN = 10;    
                    
MFRC522 rfid(SS_PIN, RST_PIN);           
         


void setup() { 
  
  Serial.begin(9600);                     
  SPI.begin();                            
  rfid.PCD_Init();          
  Wire.begin();
}
 
void loop() {
  
if(rfid.PICC_IsNewCardPresent())
{
if(rfid.PICC_ReadCardSerial())
{
Serial.print(rfid.uid.uidByte[0]);
Serial.println(rfid.uid.uidByte[1]);
}  
     
    rfid.PICC_HaltA();    
       
}}
       
