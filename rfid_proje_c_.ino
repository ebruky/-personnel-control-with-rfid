#include <SPI.h>          //iletişimi sağlamak için gerekli kütüphane                
#include <MFRC522.h>      //RFID modülü için gerekli kütüphane .
#include <Wire.h>
#include <LiquidCrystal_I2C.h>  //LCD için gerekli kütüphane 

LiquidCrystal_I2C lcd(0x3F,2,1,0,4,5,6,7,3,POSITIVE);   //lcd ayar tanımlanması
#define role 7      //role pini
int RST_PIN = 9;     //rfid reset pini              
int SS_PIN = 10;    //rfid set pini
 MFRC522 rfid(SS_PIN, RST_PIN);           
void setup() { 
  pinMode(role,OUTPUT);
  Serial.begin(9600);                     
  SPI.begin();                            
  rfid.PCD_Init();          
  Wire.begin();
  digitalWrite(role,HIGH);
 lcd.begin(16,2);

 lcd.setBacklight(HIGH);
 lcd.clear();
 
}
 
void loop() {
  
if(rfid.PICC_IsNewCardPresent())
{
if(rfid.PICC_ReadCardSerial())
{
Serial.print(rfid.uid.uidByte[0]);
Serial.println(rfid.uid.uidByte[1]);
delay(8000);
if(Serial.available())
{  
char gelen=Serial.read();
if(gelen=='1'){
       digitalWrite(role,LOW);               
       lcd.clear(); 
        lcd.setCursor(0,0);
        lcd.print("yetkili kart");
        delay(3000);
        lcd.clear();
        digitalWrite(role,HIGH);                
       
        }
else{ lcd.clear();                              
        lcd.setCursor(1,0);
        lcd.write("Gecersiz Kart");
        delay(3000);
        lcd.clear();}

} 
 }
     
    rfid.PICC_HaltA();    
       
}}
       
