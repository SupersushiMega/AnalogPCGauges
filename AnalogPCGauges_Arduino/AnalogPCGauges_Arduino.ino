//byte Brightness = 0;
int incomingByte;
int RXBuffer[] = {0, 0, 0, 0};
int RXCounter;
uint8_t AnalogOut[] = {0, 0, 0, 0};
uint8_t AnalogOutPins[] = {3, 5, 6, 9};
uint8_t Output = 0;
const uint8_t SpeedDivision = 10;


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
      RXCounter = 0;
    }
  }
    else
    {
      RXCounter = 0;
      if(Output > 3)
      {
        Output = 0;
      }
      if (RXBuffer[Output] < AnalogOut[Output])
      {
        AnalogOut[Output] -= (AnalogOut[Output] - RXBuffer[Output]) / SpeedDivision;
        analogWrite(AnalogOutPins[Output], AnalogOut[Output]);
      }
    
      else if (RXBuffer[Output] > AnalogOut[Output])
      {
        AnalogOut[Output] += (RXBuffer[Output] - AnalogOut[Output]) / SpeedDivision;
        analogWrite(AnalogOutPins[Output], AnalogOut[Output]);
      }
      Output++;
    }
  delay(10);
  
  
}
