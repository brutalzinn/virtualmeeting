# VirtualMeetingMonitor

[![VirtualMeetingMonitor-APP](https://github.com/brutalzinn/zoom-monitor-googlesheets/actions/workflows/CI.yml/badge.svg?branch=master)](https://github.com/brutalzinn/zoom-monitor-googlesheets/actions/workflows/CI.yml)

This project is based on [makeratplay/VirtualMeetingMonitor project
](https://github.com/makeratplay/VirtualMeetingMonitor)
and will be used to detect my join to zoom meeting and write a log to a google sheets table.

### Contributors to this project

    Thanks to Michael Hawkins to give us a cool project to detect virtual meetings.

    Thanks to Marcos Placona to writes a cool article about how to integrate google sheets with c#

> This application has a multi language support. You can create your own translation or uses english or portuguese translation.

# Requirements

* Visual Studio 2017+
* Google Cloud Plataform Account
* Net Framework 4.8

# Installation 

1. Create a new google cloud plataform project.
2. Select your project and enable Google Drive API and Google Sheets API from your Google Cloud Plataform account.
3. Generate a credential of account service to you google cloud project and check json option.
4. When you create a  API service account credential, a download of json file will be started.
5. Rename this json file to client_secret.json and move it to output directory of compilator
6. Access the json file your already downloaded, copy the client_email value at json and copy your application email.  Go to your google sheets table, and click the button "Share". Click on textbox "Add people and groups" and paste your application email. After, select Editor Permission at role menu. Click on submit button.


You can read the article of Marcos Placona here: 
[Click here](https://www.twilio.com/blog/2017/03/google-spreadsheets-and-net-core.html?utm_source=youtube&utm_medium=video&utm_campaign=google-sheets-dotnet)

You can watch the best tutorial of world to how to detect meetings with C# and udp packet detection here:
[https://youtu.be/sqYLpXk6cFc](https://youtu.be/sqYLpXk6cFc)

