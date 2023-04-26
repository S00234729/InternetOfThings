int player_score = 0;
int AI_score = 0;
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
        case 'P':
            player_score = player_score + 1;
            break;

        case 'S':
            AI_score = AI_score + 1;
            break;
        
    }

    lcd.setCursor(0, 1);

    lcd.print("Player 1 Score:");
    lcd.print(player_score);


    lcd.setCursor(1, 1);
    lcd.print("Player 2 Score:");
    lcd.print(AI_score);
    
}
