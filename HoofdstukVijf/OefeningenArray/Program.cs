//Maak een array die 6 strings kan bevatten. Ieder element van de array bevat een vraag (naar keuze te verzinnen) 
//als string waar de gebruiker met een getal op moet antwoorden. Maak een array aan die tot 6 ints kan bevatten.
//Lees 1 voor 1 de vraag uit de string-array uit en toon deze op het scherm. Lees vervolgens het antwoord uit dat de gebruiker intypt en bewaar dit als int in de 2e array.
//Na de 6 vragen toon je vervolgens de vragen opnieuw met achter iedere vraag het antwoord van de gebruiker.
using OefeningenArray;

Functions function = new Functions();
const int AMOUNTOFQUESTIONS = 3;
string[] questions = function.GetQuestions(AMOUNTOFQUESTIONS);
int[] answers = function.GetCorrectAnswers(AMOUNTOFQUESTIONS);
int[] userAnswers = new int[AMOUNTOFQUESTIONS];

function.PromptUserForAnswers(questions, userAnswers);
function.PrintUserAnswers(questions, userAnswers, answers);



