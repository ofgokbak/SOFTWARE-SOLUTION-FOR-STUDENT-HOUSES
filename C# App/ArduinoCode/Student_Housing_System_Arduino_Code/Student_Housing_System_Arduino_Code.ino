#include "Display.h"

const int LED_GREEN = 5;     // Initializing GREEN LED
const int Buzzer = 3;        // Play some music
const int PIN_LDR = 16;
const int btnFloor = 9;      // Navigation button for the floors
const int btnSelect = 8;     // Saves the current floor

bool isBtnFloorPressed = false;
bool isBtnSelectPressed = false;

int toggle = 0;
int currentFloor = 1;
int newFloor = 0;
float lux;

void setup()
{

  pinMode(LED_GREEN, OUTPUT);        // Configures the specified pin to behave either as an input or an output.
  pinMode(Buzzer, OUTPUT);           // Configures the specified pin to behave either as an input or an output.
  pinMode(PIN_LDR, INPUT);
  pinMode(btnFloor, INPUT_PULLUP);
  pinMode(btnSelect, INPUT_PULLUP);
  Serial.begin(9600);
  Display.show(1);
}

void loop()
{
  int buttonStateOne = digitalRead(btnFloor);
  int buttonStateTwo = digitalRead(btnSelect);
  getbrightness();

  // The right digit will always show the selected floor
  // The left digit will always show the new floor that might get selected
  if (newFloor == 0)
    Display.show(currentFloor);
  else
    Display.showDigitAt(0, newFloor);

  if (toggle == 0)
  {
    if (lux > 35)
    {
      toggle = 1;
      
      // If the alarm triggers and there is an unsaved new floor he will get reset
      newFloor = 0;
      
      // Sends the number of the current floor to the visual studio solution
      Serial.println(currentFloor);
      blinkgreen();
    }
  }
  else if (toggle == 1)
  {
    if (lux < 15)
    {
      toggle = 0;
    }
  }

  // Checks whether the button is pressed and has a boolean to prevent multiple inputs with a single button click
  if (buttonStateOne == LOW && !isBtnFloorPressed)
  {
    isBtnFloorPressed = true;

    // Switches the new floor by always skipping the current floor's number, to prevent one redundant input as an option
    if (newFloor < 5)
    {
      newFloor++;
    }
    else
      newFloor = 1;
    if (newFloor == currentFloor && newFloor != 5)
      newFloor++;
    else if (newFloor == currentFloor && newFloor == 5)
      newFloor = 1;
  }

  // Resets the boolean preventing multiple inputs when the button is released
  if (buttonStateOne == HIGH && isBtnFloorPressed)
    isBtnFloorPressed = false;

  // Checks whether the button is pressed and has a boolean to prevent multiple inputs
  // with a single button click and skips inputs without an actual new floor
  if (buttonStateTwo == LOW && !isBtnSelectPressed && newFloor != 0)
  {
    isBtnSelectPressed = true;

    // saves the new floor for the thrash as the current one
    currentFloor = newFloor;
    newFloor = 0;
  }

  // Resets the boolean for multiple inputs when the button is released
  if (buttonStateTwo == HIGH && isBtnSelectPressed)
    isBtnSelectPressed = false;
}

void getbrightness()
{
  // read the analog value
  int sensorValue = analogRead(PIN_LDR);
  float resistance_sensor;
  // and convert to resistance in Kohms
  resistance_sensor = (float)(1023 - sensorValue) * 10 / sensorValue;

  // convert the resitance to Lux
  lux = 325 * pow(resistance_sensor, -1.4);
}

// Blinksgreen
void blinkgreen()
{
  digitalWrite(LED_GREEN, HIGH);           // Turn on the Green LED
  tonecorrect();
  delay(500);                              // Delays for 0.1 second.
  digitalWrite(LED_GREEN, LOW);            // Turn off the Green LED
}

void tonecorrect()
{
  tone(Buzzer, 1000); // Send 1KHz sound signal...
  delay(100);        // ...for 0.1 sec
  noTone(Buzzer);     // Stop sound...
  delay(100);        // ...for 0.1sec
}
