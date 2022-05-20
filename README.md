# Frends.Testowy.Task2

frends Community Task for UpperClass

[![Actions Status](https://github.com/CommunityHiQ/Frends.Testowy.Task2/workflows/PackAndPushAfterMerge/badge.svg)](https://github.com/CommunityHiQ/Frends.Testowy.Task2/actions) ![MyGet](https://img.shields.io/myget/frends-community/v/Frends.Testowy.Task2) [![License: UNLICENSED](https://img.shields.io/badge/License-UNLICENSED-yellow.svg)](https://opensource.org/licenses/UNLICENSED) 

- [Installing](#installing)
- [Tasks](#tasks)
     - [TextConvert](#UpperClass)
- [Building](#building)
- [Contributing](#contributing)
- [Change Log](#change-log)

# Installing

You can install the Task via frends UI Task View or you can find the NuGet package from the following NuGet feed
https://www.myget.org/F/frends-community/api/v3/index.json and in Gallery view in MyGet https://www.myget.org/feed/frends-community/package/nuget/Frends.Testowy.Task2

# Tasks

## TextConvert

Convert a Text

### Parameters

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| InputText | `string` | Some string that will be converted. | `blabla` |

### Options

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| TextAction | `string` | What to do with input text | `Uppercase` |


### Returns

A result object with parameters.

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| OutputText | `string` | Converted string. | `BLABLA` |
| Status | `string` | Converted string. | `Text converted - To Upper` |

Usage:
To fetch result use syntax:

`#result.OutputText`

# Building

Clone a copy of the repository

`git clone https://github.com/CommunityHiQ/Frends.Testowy.Task2.git`

Rebuild the project

`dotnet build`

Run tests

`dotnet test`

Create a NuGet package

`dotnet pack --configuration Release`

# Contributing
When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

1. Fork the repository on GitHub
2. Clone the project to your own machine
3. Commit changes to your own branch
4. Push your work back up to your fork
5. Submit a Pull request so that we can review your changes

NOTE: Be sure to merge the latest from "upstream" before making a pull request!

# Change Log

| Version | Changes |
| ------- | ------- |
| 0.0.6   | Development still going on |
