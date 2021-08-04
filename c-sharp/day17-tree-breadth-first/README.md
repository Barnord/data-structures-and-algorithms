# Challenge Summary

Make a method that takes no arguments and itterates through a tree and returns a list of all values.

## WhiteBoard Process
![](Code-Challenge-17.png)

## Approach & Efficiency
This is just level order traversal, I don't know what more to say for approach than that. The Big O for time is N, since each individual node takes the same amount of time to itterate. The big O for space is based on the width of the tree.

## Solution
Starting with the root, we add each node to a queue instantiated inside the method. We then dequeue our one node queue in a while loop with the break condition of the queue being empty. Each time we dequeue a node, we look for a right and a left property of the currently selected node, adding them to the end of the queue if they're present. We also add the current value to a list, that we return.

[<==Back](../README.md)
