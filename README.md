# JetBrains Rider slow debugging performance on Apple Silicon

## tl;dr
Execution of .NET apps in Rider debug mode is much slower than VSCode debug mode (on Mac ARM).
This example project tries to reproduce the issue.

[YouTrack WorkItem](https://youtrack.jetbrains.com/issue/RIDER-102875)

## Example project observations
### Calculating Fibonacci sequence in 10 parallel tasks
#### Rider
* Debug: `Time elapsed: 00:00:10.2226907`
* Run: `Time elapsed: 00:00:03.3579881`

#### VSCode
* Debug: `Time elapsed: 00:00:10.1886414`
* Run: `Time elapsed: 00:00:02.2878069`