# ASP.NET

## creation of project
- dotnet new webapi
- Return type: IActionResult 

-- Ok()
-- NoContent()
-- BadRequest()
-- Unauthorized()
-- NotFound()
-- UnSupportedMediaType()

--Created(url,data) : for any Http POST it adds location header to the created resource to the response.

- These above return status codes for any action performed
- Objects can also be returned alongside status code. They need different but similar functions.

-- Redirect(url) : redirects to given url

-- LocalRedirect(url) : redirects to {baseUrl}+url

-- RedirectToAction(name) : redirects to location represented by function 'name' in same controller file

- Above give the gist of redirection in asp.net

- Since I'm only looking at API's for now, I didn't look deeply into Content Results: (View, PartialView, JSON, Content)
