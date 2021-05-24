// Put your code here
console.log("Let's roll some dice, baby!");
console.log("---------------------------");

const roll = () => {
    return Math.ceil(Math.random()*6)
}

const dieFace= (die) => {
    let dieRollImg = ""
    switch (die) {
        
        case 1:
            dieRollImg = "\u2680";
                break;
        case 2:
            dieRollImg = "\u2681";
            break;
        case 3:
            dieRollImg = "\u2682";
            break;    
        case 4:
            dieRollImg = "\u2683";
            break;
        case 5:
            dieRollImg = "\u2684";
            break;
        case 6:
            dieRollImg = "\u2685";
            break;
    
        default:
            break;
    }
    return dieRollImg;

}
const rollDice = () => {
for (let i = 0; i < 10; i++)
{
   const die1 = roll();
   const die2 = roll();
    // console.log(`${die1} + ${die2} == ${die1 + die2}`)
    let message = `${dieFace(die1)} + ${dieFace(die2)} == ${die1 + die2}`;
    if (die1 === die2)
    {
        message += " DOUBLES!";
    }

    console.log(message);
}
}

rollDice();

