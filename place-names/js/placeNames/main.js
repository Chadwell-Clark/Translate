// Put your code here

// We must specify the Type of the "names" variable.
//  It is a "List" that can only contain "strings".
const names = [ "Nashville", "Hong Kong", "The back yard", "Earth",
"London", "The mall", "Ryman Auditorium", "The Great Wall of China"];

// Print some output to the terminal (aka. "Console");
names.forEach(name => {
    console.log(name);
});

// When you don't pass an argument to WriteLine, it simply outputs a blank line.
//  Here we use that to add a little space around the output.
console.log("");

// Filter the list to create a new list that only has 
//  place names that start with the word "The".
console.log("'The' Place Names")

const theNames = names.filter(name => name.includes("The"));
theNames.map(name => console.log(name))

