# JetBrains Rider slow debugging performance on Apple Silicon

## tl;dr
Execution of .NET apps in Rider debug mode is much slower than VSCode debug mode (on Mac ARM).
This example project tries to reproduce the issue.

[YouTrack WorkItem](https://youtrack.jetbrains.com/issue/RIDER-102875)

## Example project observations

#### Rider
* Run:
  * `RunParallelFibonacciTasks time elapsed: 00:00:04.8026837`
  * `RunParallelHttpRequests time elapsed: 00:00:00.3663711`
* Debug:
  * `RunParallelFibonacciTasks time elapsed: 00:00:14.5348484`
  * `RunParallelHttpRequests time elapsed: 00:00:01.0609222`

#### VSCode
* Run:
  * `RunParallelFibonacciTasks time elapsed: 00:00:04.3853632`
  * `RunParallelHttpRequests time elapsed: 00:00:00.3147610`
* Debug:
  * `RunParallelFibonacciTasks time elapsed: 00:00:04.3754359`
    `RunParallelHttpRequests time elapsed: 00:00:00.2788305`