
int baskelballFee = int.Parse(Console.ReadLine());

double basketballSneakers = baskelballFee * 0.6;     // -40%    
double basketballUniform = basketballSneakers * 0.8; // -20%
double basketballBall = basketballUniform / 4;       // * 0.25
double basketballAccessories = basketballBall / 5;   // * 0.2

double finalSum = baskelballFee + basketballSneakers + basketballUniform + basketballBall + basketballAccessories;

Console.WriteLine(finalSum);
