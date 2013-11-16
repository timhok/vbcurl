vbcurl
======

Simple interaction with http for VB.net / С#

## Installation

There is no need to install,
In Visual Studio press Ctrl+D and select this file,
it will be included to you project and ready to use.

## Usage
### Get request
```vb
vbcurl.get_(url as string) as string
```
```vb
html = vbcurl.get_("http://google.com/")
```
Note: specifying the protocol is required.

### Post request

```vb
vbcurl.post(url as string, optional post-data as string) as string
```
```vb
scsf = vbcurl.post("https://test.com/","prila=upala")
```

## Working with cookies
### Set Cookies

```vb
vbcurl.setcookie(string array())
```
```vb
setcookie({"code=1337","q=lax"})
```

### Get Cookies

```vb
result = vbcurl.cookie
```
