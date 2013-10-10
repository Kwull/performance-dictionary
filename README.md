.NET BCL collections performance
======================

Sometimes there is need to understand how the .NET BCL collection classes performs. This can help to choose proper collection for a solution. Bellow you can find the performance measurement and the BCL collections lookup and manipulation efficiency analyses.
In the [C#/.NET Fundamentals: Choosing the Right Collection Class](http://geekswithblogs.net/BlackRabbitCoder/archive/2011/06/16/c.net-fundamentals-choosing-the-right-collection-class.aspx) blogpost you can find additional details.

## Performance measurement

Each collection were accessed 3 times: at the begin of a collection, at the middle, at the end. Size is the number of elements in the collection.
Tests were run for 1.000.000 times and total time measured in milliseconds.

## Results

Name	| Size	| Begin	| Middle | End
--- | --- | --- | --- | ---
ConcurrentDictionary | 1000 | 440 | 441 | 432
ConcurrentDictionary | 10000 | 445 | 451 | 448
ConcurrentDictionary | 100000 | 458 | 485 | 486
ConcurrentDictionary | 1000000 | 483 | 483 | 457
Dictionary | 1000 | 431 | 432 | 422
Dictionary | 10000 | 438 | 440 | 432
Dictionary | 100000 | 427 | 449 | 448
Dictionary | 1000000 | 436 | 454 | 451
HashSet | 1000 | 433 | 437 | 424
HashSet | 10000 | 446 | 446 | 424
HashSet | 100000 | 431 | 457 | 442
HashSet | 1000000 | 440 | 475 | 439
Hashtable | 1000 | 434 | 442 | 445
Hashtable | 10000 | 436 | 443 | 460
Hashtable | 100000 | 448 | 455 | 481
Hashtable | 1000000 | 450 | 519 | 563
List | 1000 | 491 | 8327 | 17340
List | 10000 | 673 | 79260 | 169412
List | 100000 | 5038 | 868709 | 1815954
List | 1000000 | 7249 | 8570125 | 18169534
NameValueCollection | 1000 | 1401 | 1413 | 1408
NameValueCollection | 10000 | 1406 | 1441 | 1438
NameValueCollection | 100000 | 1417 | 1473 | 1527
NameValueCollection | 1000000 | 1460 | 1525 | 1607
SortedDictionary | 1000 | 1703 | 1751 | 2290
SortedDictionary | 10000 | 2124 | 2348 | 3443
SortedDictionary | 100000 | 2542 | 2530 | 4068
SortedDictionary | 1000000 | 3160 | 3266 | 4548
SortedList | 1000 | 1699 | 1594 | 1857
SortedList | 10000 | 2233 | 2290 | 2428
SortedList | 100000 | 2645 | 2871 | 2870
SortedList | 1000000 | 3042 | 3164 | 3336
SortedSet | 1000 | 1645 | 1688 | 2205
SortedSet | 10000 | 2060 | 2287 | 3327
SortedSet | 100000 | 2476 | 2409 | 3945
SortedSet | 1000000 | 3042 | 3139 | 4368
