# XOR Prediction by training a neural network

This is a simple application to demonstrate how we can use .Net and the Accord library to build AI applications.

## Table of Contents

1. [Prerequisite](#prerequisite)
1. [Installation](#installation)
1. [How does it work?](#how-does-it-work)

### Prerequisite
1. Visual Studio 2017
2. Accord 


### Installation
Please install the following Accord nuget packages to run the application.
```
Install-Package Accord
Install-Package Accord.MachineLearning
Install-Package Accord.Neuro
```


### How does it work

The application has two parts to it. First, you train the neural network by providing the expected inputs and its corresponding outputs.
The more you train the network, the better it becomes in predicting. Once you run the app, you will be asked to enter the *iteration count*,
which is the number of times you want to train the network.

The *RunEpoch* method returns the learning errors. You can see that as the iteration count increases the error rate becomes closer to zero, which means that the learning of the network as improved.

Once the network is trained, you can input the X and Y values for which you want the output to be predicted.


**Thank you!**

**[Back to top](#table-of-contents)**








