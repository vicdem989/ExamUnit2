using HTTPUtils;
using System.Text.Json;
using AnsiTools;
using Colors = AnsiTools.ANSICodes.Colors;
using tasks;

Console.Clear();
Console.WriteLine("Starting Assignment 2");

// SETUP 
const string myPersonalID = "ec9876325b5904354be72a2d6413bde81d858754bff32560beab1aedc16ff71d";
const string baseURL = "https://mm-203-module-2-server.onrender.com/";
const string startEndpoint = "start/"; // baseURl + startEndpoint + myPersonalID
const string taskEndpoint = "task/";   // baseURl + taskEndpoint + myPersonalID + "/" + taskID

// Creating a variable for the HttpUtils so that we dont have to type HttpUtils.instance every time we want to use it
HttpUtils httpUtils = HttpUtils.instance;

// #### REGISTRATION
// We start by registering and getting the first task

Response startRespons = await httpUtils.Get(baseURL + startEndpoint + myPersonalID);
Console.WriteLine($"Start:\n{Colors.Magenta}{startRespons}{ANSICodes.Reset}\n\n"); // Print the response from the server to the console

string taskID = "aAaa23"; // We get the taskID from the previous response and use it to get the task (look at the console output to find the taskID)*/


// #### FIRST TASK
// Fetch the details of the task from the server.

Response task1Response = await httpUtils.Get(baseURL + taskEndpoint + myPersonalID + "/" + taskID); // Get the task from the server
Task task1 = JsonSerializer.Deserialize<Task>(task1Response.content);
Console.WriteLine($"TASK 1: {ANSICodes.Effects.Bold}{task1?.title}{ANSICodes.Reset}\n{task1?.description}\nParameters: {Colors.Yellow}{task1?.parameters}{ANSICodes.Reset}");

double task1Answer = Tasks.Task1(task1.parameters);

Response task1AnswerResponse = await httpUtils.Post(baseURL + taskEndpoint + myPersonalID + "/" + taskID, task1Answer.ToString());
Console.WriteLine($"\nAnswer: {Colors.Green}{task1AnswerResponse}{ANSICodes.Reset}");

taskID = "KO1pD3"; // We get the taskID from the previous response and use it to get the task (look at the console output to find the taskID)

Console.WriteLine("\n-----------------------------------\n");



// #### SECOND TASK
// Fetch the details of the task from the server.
Response task2Response = await httpUtils.Get(baseURL + taskEndpoint + myPersonalID + "/" + taskID); // Get the task from the server
Task task2 = JsonSerializer.Deserialize<Task>(task2Response.content);
Console.WriteLine($"TASK 2: {ANSICodes.Effects.Bold}{task2?.title}{ANSICodes.Reset}\n{task2?.description}\nParameters: {Colors.Yellow}{task2?.parameters}{ANSICodes.Reset}");

string task2Answer = Tasks.Task2(task2.parameters);


// Send the answer to the server
Response task2AnswerResponse = await httpUtils.Post(baseURL + taskEndpoint + myPersonalID + "/" + taskID, task2Answer);
Console.WriteLine($"\nAnswer: {Colors.Green}{task2AnswerResponse}{ANSICodes.Reset}");

taskID = "aLp96";

Console.WriteLine("\n-----------------------------------\n");


// #### THIRD TASK
// Fetch the details of the task from the server.
Response task3Response = await httpUtils.Get(baseURL + taskEndpoint + myPersonalID + "/" + taskID); // Get the task from the server
Task task3 = JsonSerializer.Deserialize<Task>(task3Response.content);
Console.WriteLine($"TASK  3: {ANSICodes.Effects.Bold}{task3?.title}{ANSICodes.Reset}\n{task3?.description}\nParameters: {Colors.Yellow}{task3?.parameters}{ANSICodes.Reset}");

string task3Answer = Tasks.Task3(task3.parameters);


// Send the answer to the server
Response task3AnswerResponse = await httpUtils.Post(baseURL + taskEndpoint + myPersonalID + "/" + taskID, task3Answer);
Console.WriteLine($"\nAnswer: {Colors.Green}{task3AnswerResponse}{ANSICodes.Reset}");

taskID = "rEu25ZX";

Console.WriteLine("\n-----------------------------------\n");


// #### FOURTH TASK
// Fetch the details of the task from the server.
Response task4Response = await httpUtils.Get(baseURL + taskEndpoint + myPersonalID + "/" + taskID); // Get the task from the server
Task task4 = JsonSerializer.Deserialize<Task>(task4Response.content);
Console.WriteLine($"TASK 4: {ANSICodes.Effects.Bold}{task4?.title}{ANSICodes.Reset}\n{task4?.description}\nParameters: {Colors.Yellow}{task4?.parameters}{ANSICodes.Reset}");

string task4Answer = Tasks.Task4(task4.parameters);
Console.WriteLine(task4.parameters + "  is " + task4Answer);


Response task4AnswerResponse = await httpUtils.Post(baseURL + taskEndpoint + myPersonalID + "/" + taskID, task4Answer);
Console.WriteLine($"\nAnswer: {Colors.Green}{task4AnswerResponse}{ANSICodes.Reset}");


public class Task
{
    public string? title { get; set; }
    public string? description { get; set; }
    public string? taskID { get; set; }
    public string? usierID { get; set; }
    public string? parameters { get; set; }
}