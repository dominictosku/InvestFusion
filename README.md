# MAUI-Blazor Excel File Upload and Processing
For managing and analysing your stock and cryptos in one place. Useful for filling out tax return.

This Blazor WebAssembly project allows to upload Excel files (.xlsx, .xls), parse them, and display their contents as objects within the application. The project uses EPPlus to read Excel files client-side and converts them into a list of custom class objects.

## Features

- File upload limited to Excel files (.xlsx and .xls).
- Parsing Excel files to read data into a custom `Stock` class.
- Displaying the parsed data in a user-friendly format.

## Supported Broker
- Swissquote
- Degiro
- Coinbase
- Crypto.com

## Prerequisites

- .NET 8.0 SDK or later
- MAUI Workload (Can be installed in VS installer)
- A compatible web browser (Chrome, Firefox, Edge, etc.)
- Visual Studio 2022 or Visual Studio Code

## Getting Started

Follow these steps to get your project up and running:

1. **Clone the repository:**

```bash
git clone https://github.com/dominictosku/InvestFusion
cd InvestFusion
```

2. **Run the application:**

Select "Windows Machine" as start project and click run

or

You can run the application using the following command:

```bash
dotnet run
````

## Usage
- Use the file input to select an Excel file to upload.
- The file contents will be displayed on the page once the file is processed.
- A sample file is included inside "Examples" folder
