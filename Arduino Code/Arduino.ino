int score = 0;
#include <Wire.h>
#include "rgb_lcd.h"

rgb_lcd lcd;



const int colorR = 255;
const int colorG = 0;
const int colorB = 150;


void setup() {

  lcd.begin(16, 2);

  lcd.setRGB(colorR, colorG, colorB);
 
  Serial.begin(9600);

}

void loop()
{


    switch (Serial.read())
    {
        case 'S':
            score = score + 1;
            break;
        
    }

    lcd.setCursor(1, 1);

    lcd.print("Your Score");
    lcd.print(score);
    
}
