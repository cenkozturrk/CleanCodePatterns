# Singleton Pattern

## Overview
The purpose of the singleton design pattern is to ensure that a class only has one instance and provide a global point of access to it throughout the life of an application. Access of one instance is preferred to avoid unexpected results.


## Key Features
- We used the Lazy<T> type to ensure lazy initialization of the Logger instance.
- Marked the Logger class as sealed to prevent inheritance.
- Declared a private constructor to prevent external instantiation.
- Implemented a thread-safe lock mechanism to prevent race conditions when multiple threads write to the log file.
- ***The LOCK (_lock) statement*** ensures that only one thread can execute the code block inside it at a time. This is used to prevent race conditions when multiple threads attempt to write to the log file simultaneously. By locking _lock, we ensure that log entries are written sequentially, preventing corruption or data loss in the log file.

