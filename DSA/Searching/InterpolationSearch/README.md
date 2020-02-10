#  Interpolation search

Interpolation search is an algorithm for searching for a key in an array that has been ordered by numerical values assigned to the keys (key values). It was first described by W. W. Peterson in 1957. Interpolation search resembles the method by which people search a telephone directory for a name (the key value by which the book's entries are ordered) in each step the algorithm calculates where in the remaining search space the sought item might be, based on the key values at the bounds of the search space and the value of the sought key, usually via a linear interpolation. The key value actually found at this estimated position is then compared to the key value being sought. If it is not equal, then depending on the comparison, the remaining search space is reduced to the part before or after the estimated position. This method will only work if calculations on the size of differences between key values are sensible.

## Algorithm

Rest of the Interpolation algorithm is the same except the above partition logic.

* Step1: In a loop, calculate the value of “pos” using the probe position formula.
* Step2: If it is a match, return the index of the item, and exit.
* Step3: If the item is less than arr[pos], calculate the probe position of the left sub-array. Otherwise calculate the same in the right sub-array.
* Step4: Repeat until a match is found or the sub-array reduces to zero.

## Example

<img src="https://cfvod.kaltura.com/p/1926081/sp/192608100/thumbnail/entry_id/0_10lkpzmw/version/100000/width/372/height/209">

## More

* [Wiki](https://en.wikipedia.org/wiki/Interpolation_search)
* [Geeksforgeeks](https://www.geeksforgeeks.org/interpolation-search/)