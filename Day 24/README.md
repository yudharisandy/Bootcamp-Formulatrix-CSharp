# Debugging Technique
Debugging is must-have skill by SE, it will useful for identifying and fixing problems. Here are three debugging techniques that can help SE more effective and efficient -> debugging mindset.

## Quit Thinking and Look
- You can close your eyes, lean back in your chair, and brainstorm possible sources of the bug all day long. Maybe one of those ideas is correct. But you won’t really know until you **stop thinking and start exploring**. Pull out your proverbial stick and start poking around in the system. See what breaks, who yells.
- Example: 
    - Find a good sorting algorithm, and implement it.
    - Let's say, implement Quicksort algorithm.
    - Problem: Bug in choosing Pivot or Partitioning.
    - Instead of just thinking, it is better to try the ideas out.

## Divide and Conquer
- Start eliminating possible sources of the bug, ideally via a binary search algorithm. Eliminate half the system as a bug-harboring candidate. Then eliminate the next half, and the next half, until the bug is staring at you sheepishly with its creepy bug tail between its legs.
- Example:
    - Quicksort ALgorithm.

## Change One Thing at a Time
- Don’t change a million things at once. **Change one variable and retest**. Did anything change? Put it back the way you found it.;try another one. This systematic method seems tedious, but you often **save time in the long run**.
- Example: 
    - In the LudoGame, Collision rule Bug: Send enemy's totem back to the home position.
    - Initially, a Totem has two position variables: ```HomePosition``` and ```Position```.
    - When Collision happen, Library has been successfully change the ```Position = HomePosition```.
    - Problem: GUI needs to delete a Totem from ```Position```, but the Position has been changed to ```HomePosition```.
    - Solution: Add ```PreviousPosition``` variable, GUI will delete the Totem from there.





## References:
- [[Book Review] Debugging: The 9 Indispensable Rules for Finding Even the Most Elusive Software and Hardware Problems](https://www.tygertec.com/9-rules-debugging)
- 


