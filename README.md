# JetBrains Rider slow debugging performance on Apple Silicon

## tl;dr
Execution of .NET apps in Rider debug mode is much slower than VSCode debug mode (on Mac ARM).
This example project tries to reproduce the issue.

[YouTrack WorkItem](https://youtrack.jetbrains.com/issue/RIDER-102875)

## Example project observations

#### Rider
* Debug:
  * `RunParallelFibonacciTasks time elapsed: 00:00:03.5374621`
  * `RunParallelHttpRequests time elapsed: 00:00:00.1801813`
* Run:
  * `RunParallelFibonacciTasks time elapsed: 00:00:10.2185010`
  * `RunParallelHttpRequests time elapsed: 00:00:00.5150336`

#### VSCode
* Debug: 
  * `RunParallelFibonacciTasks time elapsed: 00:00:10.2544012`
  * `RunParallelHttpRequests time elapsed: 00:00:00.2719139`
* Run: 
  * `RunParallelFibonacciTasks time elapsed: 00:00:02.2207867`
  * `RunParallelHttpRequests time elapsed: 00:00:00.1975888`
