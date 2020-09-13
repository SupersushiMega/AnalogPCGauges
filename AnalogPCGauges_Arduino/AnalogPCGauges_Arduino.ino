//byte Brightness = 0;
int incomingByte;
int RXBuffer[] = {0, 0, 0, 0};
int RXCounter;
int AnalogOut[] = {0, 0, 0, 0};


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  RXCounter = 0;
}

void loop() {
  if (RXBuffer[0] < AnalogOut[0])
  {
    AnalogOut[0]--;
    analogWrite(3, AnalogOut[0]);
  }

  if (RXBuffer[0] > AnalogOut[0])
  {
    AnalogOut[0]++;
    analogWrite(3, AnalogOut[0]);
  }
  
  if (Serial.available() > 0) {
    RXBuffer[RXCounter] = Serial.read();
    RXCounter++;
    if(RXCounter > 3){
      Serial.print(RXBuffer[1], DEC);
      Serial.print(", ");
      Serial.print(RXBuffer[2], DEC);
      Serial.print(", ");
      Serial.println(RXBuffer[3], DEC);
      analogWrite(5, RXBuffer[1]);
      RXCounter = 0;
    }
    // read the incoming byte:
    //incomingByte = Serial.read();

    // say what you got:
    //Serial.readBytesUntil(
    //analogWrite(3, incomingByte);
  }
    else
    {
      RXCounter = 0;
    }
  // put your main code here, to run repeatedly:
  //Brightness--;
 
  //Serial.println(Brightness);
  //analogWrite(3, 127);
  delay(10);
  
  
}
