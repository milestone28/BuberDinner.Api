# Buber Dinner API

Table of Contents(up to date)
- [Buber Dinner API](#buber-dinner-api)
	- [Auth](#auth)
		- [Register](#register)
			- [Register Request](#register-request)
			- [Register Response](#register-response)
		- [Login](#login)
			- [Login Request](#login-request)
			- [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
	"id" : "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
	"firstName" : "Gary",
	"lastName" : "Yu",
	"email" : "garz090289@gmail.com",
	"password" : "gary1234"
}
```

### Register Response

```js
200 OK
```

```json
{
	"id" : "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
	"firstName" : "Gary",
	"lastName" : "Yu",
	"email" : "garz090289@gmail.com",
	"token" : "eyJhb..hbbQ"
}
```
### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
	"email" : "garz090289@gmail.com",
	"password" : "gary1234"
}
```

### Login Response

```js
200 OK
```

```json
{
	"id" : "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
	"firstName" : "Gary",
	"lastName" : "Yu",
	"email" : "garz090289@gmail.com",
	"token" : "eyJhb..hbbQ"
}
```