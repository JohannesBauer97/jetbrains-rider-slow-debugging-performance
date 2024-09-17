# JetBrains Rider slow debugging performance on Apple Silicon

## tl;dr
Execution of .NET apps in Rider debug mode is much slower than VSCode debug mode (on Mac ARM).
This example project tries to reproduce the issue.

[YouTrack WorkItem](https://youtrack.jetbrains.com/issue/RIDER-102875)

## Example project observations

#### Rider
* Run:
  * `RunParallelFibonacciTasks time elapsed: 00:00:03.3856167`
  * `RunParallelHttpRequests time elapsed: 00:00:00.2774819`
* Debug:
  * `RunParallelFibonacciTasks time elapsed: 00:00:10.2523595`
  * `RunParallelHttpRequests time elapsed: 00:00:00.5442160`

#### VSCode
* Run: 
  * `RunParallelFibonacciTasks time elapsed: 00:00:02.2992337`
  * `RunParallelHttpRequests time elapsed: 00:00:00.2039228`
* Debug: 
  * `RunParallelFibonacciTasks time elapsed: 00:00:10.2194985`
  * `RunParallelHttpRequests time elapsed: 00:00:00.3564102`
