#define MR1D 2
#define MR1P 3
#define ML1D 4
#define ML1P 5
#define MR2D 6
#define MR2P 7
#define ML2D 8
#define ML2P 9

int encoderA = 20;
int encoderB = 21;
int pulses; 

int incomingByte;

void setup() {
  // put your setup code here, to run once:
  pinMode(MR1D,OUTPUT);
  pinMode(MR1P,OUTPUT);
  pinMode(ML1D,OUTPUT);
  pinMode(ML1P,OUTPUT);
  pinMode(MR2D,OUTPUT);
  pinMode(MR2P,OUTPUT);
  pinMode(ML2D,OUTPUT);
  pinMode(ML2P,OUTPUT);

  Serial.begin(9600);
  //attachInterrupt(3, A_CHANGE, CHANGE);
  
}

/*void A_CHANGE(){                                  //Function that to read the pulses in x1.
  if( digitalRead(encoderB) == 0 ) {
    if ( digitalRead(encoderA) == 0 ) {
      // A fell, B is low
      pulses--; // moving reverse
    } else {
      // A rose, B is low
      pulses++; // moving forward
    }
  }
  
}
*/
void loop() {
  // put your main code here, to run repeatedly:
    
    if (Serial.available() > 0) {
    // read the oldest byte in the serial buffer:
    incomingByte = Serial.read();
     if(pulses==245)
    {
      incomingByte='S';
    }
     switch(incomingByte)
     {
      case('F'):
        digitalWrite(MR1D,LOW);
        analogWrite(MR1P,80);
        digitalWrite(ML1D,LOW);
        analogWrite(ML1P,80);
        digitalWrite(MR2D,LOW);
        analogWrite(MR2P,80);
        digitalWrite(ML2D,LOW);
        analogWrite(ML2P,80);
        break;
      case('B'):
        digitalWrite(MR1D,HIGH);
        analogWrite(MR1P,80);
        digitalWrite(ML1D,HIGH);
        analogWrite(ML1P,80);
        digitalWrite(MR2D,HIGH);
        analogWrite(MR2P,80);
        digitalWrite(ML2D,HIGH);
        analogWrite(ML2P,80);
        break;
      case('L'):
        digitalWrite(MR1D,LOW);
        analogWrite(MR1P,80);
        digitalWrite(ML1D,HIGH);
        analogWrite(ML1P,80);
        digitalWrite(MR2D,LOW);
        analogWrite(MR2P,80);
        digitalWrite(ML2D,HIGH);
        analogWrite(ML2P,80);
        break;
      case('R'):
        digitalWrite(MR1D,HIGH);
        analogWrite(MR1P,80);
        digitalWrite(ML1D,LOW);
        analogWrite(ML1P,80);
        digitalWrite(MR2D,HIGH);
        analogWrite(MR2P,80);
        digitalWrite(ML2D,LOW);
        analogWrite(ML2P,80);
        break;
      case('S'):
        digitalWrite(MR1D,HIGH);
        analogWrite(MR1P,0);
        digitalWrite(ML1D,HIGH);
        analogWrite(ML1P,0);
        digitalWrite(MR2D,HIGH);
        analogWrite(MR2P,0);
        digitalWrite(ML2D,HIGH);
        analogWrite(ML2P,0);
        //Serial.println(pulses);
        //pulses=0;
        break;
        
     }
     }
}
