//byte Brightness = 255;
int incomingByte;
int RXBuffer[10];
int RXCounter;


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  RXCounter = 0;
}

void loop() {
  if (Serial.available() > 0) {
    RXBuffer[RXCounter] = Serial.read();
    RXCounter++;
    if(RXCounter > 3){
      Serial.print("I received: ");
      Serial.print(RXBuffer[0], DEC);
      Serial.print(", ");
      Serial.print(RXBuffer[1], DEC);
      Serial.print(", ");
      Serial.print(RXBuffer[2], DEC);
      Serial.print(", ");
      Serial.println(RXBuffer[3], DEC);
      analogWrite(3, RXBuffer[0]);
      RXCounter = 0;
    }
    // read the incoming byte:
    //incomingByte = Serial.read();

    // say what you got:
    //Serial.readBytesUntil(
    //analogWrite(3, incomingByte);
  }
  // put your main code here, to run repeatedly:
  //Brightness--;
 
  //Serial.println(Brightness);
  //analogWrite(3, 127);
  delay(10);
  
  
}
