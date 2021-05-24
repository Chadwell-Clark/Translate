// Put your code here



const allSpells = [
    {
        name : "Turn enemy into a newt",
        isEvil : true,
        energyReqired : 5.1
    },
    {
        name : "Conjure some gold for a local charity",
        isEvil : false,
        energyReqired : 2.99
    },
    {
        name : "Give a deaf person the ability to heal",
        isEvil : false,
        energyReqired : 12.2
    },
    {
        name : "Make yourself emperor of the universe",
        isEvil : true,
        energyReqired : 100.0
    },
    {
        name : "Convince your relatives your political views are correct",
        isEvil : false,
        energyReqired : 2921.5
    }
];

const makeGoodSpellBook = (allSpells) => {
    
    console.log("Good Book")
    allSpells.forEach(spell => {
        if (!spell.isEvil ) {
            console.log(spell.name)
        }
    });
}

const makeEvilSpellBook = (allSpells) => {
    
    console.log("Evil Book")
    allSpells.forEach(spell => {
        if (spell.isEvil ) {
            console.log(spell.name)
        }
    });
}

const displaySpellBook = () => {
    console.log("Do you believe in magic?");
    console.log("------------------------");
    makeGoodSpellBook(allSpells);
    console.log("");
    makeEvilSpellBook(allSpells);
}

displaySpellBook();