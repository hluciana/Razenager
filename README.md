<h1 align="center"><img src="/images/razenager.png" alt="razenager"></h1>
<h2 align="center">ALPHA v2.8.1</h2>

## Table of Contents

- [Description](#description)
- [Installation](#installation)
- [Usage](#usage)

## Description

<p>Razenager helps you get information from a <b>UPN</b> student</p>
<p>I am working on improvements and adding new features</p>
<p>You are free to modify the code in your own way and test it for educational purposes</p>

## Installation

#### Clone this repository

```
git clone https://github.com/hluciana/Razenager.git

```
#### Dependencies

<p>Go to Tools -> NuGet Package Manager -> Package Manager Console</p>

```
Update-Package -Reinstall

```
## Usage

<p>Login section(coming soon): By entering the student's credentials, you can obtain their token.</p>
<p><img src="/images/login.png" alt="login"></p>
<p>Info section:</p>

- Personal Info: By entering the student's token, you can obtain their personal information such as: DNI, full name, date of birth, contact number, etc.
- Historical grades: By entering the student's token, you can obtain the grades for all the courses they have taken in each academic term.
<div style="display:flex;">
  <img src="/images/infov1.png" alt="infov1" style="width:45%;">
  <img src="/images/infov2.png" alt="infov2" style="width:45%;">
</div>
<p>Courses section:</p>

- Get courses data: By entering the student's token, you can obtain the courses they are currently taking.
- Get course grades: By entering the sub-token of a specific course along with the student's token, you can obtain the current grades for that course.
<div style="display:flex;">
  <img src="/images/coursesv1.png" alt="coursesv1" style="width:45%;">
  <img src="/images/coursesv2.png" alt="coursesv2" style="width:45%;">
</div>
<p>Decode URL section: You can encode and decode any URL you want.</p>
<p><img src="/images/decode.png" alt="decode"></p>
<p>Config section: You can make changes to the URLs of the APIs used to obtain student data.</p>
<p><img src="/images/config.png" alt="config"></p>

##
<h4 align="center">Created by HappyLife</h1>
