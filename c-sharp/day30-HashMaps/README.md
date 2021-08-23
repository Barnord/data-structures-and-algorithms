# HashMaps

## Challenge
Implement a hashmap that can successfully add, and get values stored by keys, as well as checking if the map contains a value by key.

## Approach & Efficiency
I just did what he did in class, I don't know this stuff well enough yet.

## API

- add
  - Arguments: key, value
  - Returns: nothing
  - This method hashes the key, and adds the key value pair to the table, handling collisions as needed.

- get
  - Arguments: key
  - Returns: Value
  - This method returns the value associated with the inputted key.

- contains
  - Arguments: key
  - Returns: bool
  - This method returns true or false based on if the map contains the key.

- Hash
  - Arguments: key
  - Returns: int
  - Returns the index in the map for that key.
