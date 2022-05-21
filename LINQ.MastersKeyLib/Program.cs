// See https://aka.ms/new-console-template for more information

using LINQ.MastersKeyLib.DeferredExecution;
using LINQ.MastersKeyLib.EnumerablesMethodChainings;
using LINQ.MastersKeyLib.ExtensionMethods;
using LINQ.MastersKeyLib.LambdasAndFunc;
using LINQ.MastersKeyLib.Methods;
using LINQ.MastersKeyLib.RepositoryService;



var peopleService = new PeopleService();

var lambdasFunc = new LambdasFunc();
lambdasFunc.Execute();

Extensions extensions = new();
extensions.Execute();

Chainings chainings = new();
chainings.Execute();

DeferredExample deferredExample = new ();
deferredExample.Execute();

MethodAny methodAny = new MethodAny(peopleService);
methodAny.AnyFunction();

MethodAll methodAll = new MethodAll(peopleService);
methodAll.AllFunction();

MethodCount methodCount = new MethodCount(peopleService);
methodCount.Execute();

MethodContains methodContains = new MethodContains(peopleService);
methodContains.Execute();

MethodOrderBy methodOrderBy = new MethodOrderBy(peopleService);
methodOrderBy.Execute();
