// See https://aka.ms/new-console-template for more information

using LINQ.MastersKeyLib.DeferredExecution;
using LINQ.MastersKeyLib.EnumerablesMethodChainings;
using LINQ.MastersKeyLib.ExtensionMethods;
using LINQ.MastersKeyLib.LambdasAndFunc;
using LINQ.MastersKeyLib.Methods;

var lambdasFunc = new LambdasFunc();
lambdasFunc.Execute();

Extensions extensions = new();
extensions.Execute();

Chainings chainings = new();
chainings.Execute();

DeferredExample deferredExample = new ();
deferredExample.Execute();

MethodAny methodAny = new MethodAny();
methodAny.AnyFunction();