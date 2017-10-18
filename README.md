*****************************************************************************************
                                ToDoList
*****************************************************************************************


ToDoList is a simple application prepared in Xamarin that allows user to 
add/modify/delete to-do items.

Current version of ToDoList only supports iOS platform. However core business logic is 
added in PCL so that can be ectended to Android platform easily in future.

Application is written in C# using Xamarin best practices & it adopts MVVM design pattern. All common code 
is in ToDoLibrary which is actually a Portable Class Library.


Application uses Behaviors & Commands wherever required. It also uses DependancyService to get Platform specific feature.
