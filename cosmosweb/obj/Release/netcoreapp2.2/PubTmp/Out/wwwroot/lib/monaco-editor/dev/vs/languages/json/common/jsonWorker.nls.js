/*!-----------------------------------------------------------
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Version: 0.5.2(d49899a916fd99840f6f9178f2dd06e0e7013646)
 * Released under the MIT license
 * https://github.com/Microsoft/vscode/blob/master/LICENSE.txt
 *-----------------------------------------------------------*/

/*---------------------------------------------------------
 * Copyright (c) Microsoft Corporation. All rights reserved.
 *--------------------------------------------------------*/
define("vs/languages/json/common/jsonWorker.nls", {
	"vs/base/common/http": [
		"Bad request. The request cannot be fulfilled due to bad syntax.",
		"Unauthorized. The server is refusing to respond.",
		"Forbidden. The server is refusing to respond.",
		"Not Found. The requested location could not be found.",
		"Method not allowed. A request was made using a request method not supported by that location.",
		"Not Acceptable. The server can only generate a response that is not accepted by the client.",
		"Proxy Authentication Required. The client must first authenticate itself with the proxy.",
		"Request Timeout. The server timed out waiting for the request.",
		"Conflict. The request could not be completed because of a conflict in the request.",
		"Gone. The requested page is no longer available.",
		"Length Required. The \"Content-Length\" is not defined.",
		"Precondition Failed. The precondition given in the request evaluated to false by the server.",
		"Request Entity Too Large. The server will not accept the request, because the request entity is too large.",
		"Request-URI Too Long. The server will not accept the request, because the URL is too long.",
		"Unsupported Media Type. The server will not accept the request, because the media type is not supported.",
		"Internal Server Error.",
		"Not Implemented. The server either does not recognize the request method, or it lacks the ability to fulfill the request.",
		"Service Unavailable. The server is currently unavailable (overloaded or down).",
		"HTTP status code {0}"
	],
	"vs/languages/json/common/contributions/bowerJSONContribution": [
		"Default bower.json",
		"Request to the bower repository failed: {0}",
		"Request to the bower repository failed: {0}",
		"{0}"
	],
	"vs/languages/json/common/contributions/globPatternContribution": [
		"Files by Extension",
		"Match all files of a specific file extension.",
		"Files with Multiple Extensions",
		"Match all files with any of the file extensions.",
		"Files with Siblings by Name",
		"Match files that have siblings with the same name but a different extension.",
		"Folder by Name (Top Level)",
		"Match a top level folder with a specific name.",
		"Folders with Multiple Names (Top Level)",
		"Match multiple top level folders.",
		"Folder by Name (Any Location)",
		"Match a folder with a specific name in any location.",
		"True",
		"Enable the pattern.",
		"False",
		"Disable the pattern.",
		"Files with Siblings by Name",
		"Match files that have siblings with the same name but a different extension."
	],
	"vs/languages/json/common/contributions/packageJSONContribution": [
		"Default package.json",
		"Request to the NPM repository failed: {0}",
		"Request to the NPM repository failed: {0}",
		"The currently latest version of the package",
		"Matches the most recent major version (1.x.x)",
		"Matches the most recent minor version (1.2.x)",
		"{0}",
		"Latest version: {0}"
	],
	"vs/languages/json/common/contributions/projectJSONContribution": [
		"Default project.json",
		"Request to the nuget repository failed: {0}",
		"Request to the nuget repository failed: {0}",
		"The currently latest version of the package",
		"{0}",
		"Latest version: {0}"
	],
	"vs/languages/json/common/jsonIntellisense": [
		"Default value"
	],
	"vs/languages/json/common/jsonSchemaService": [
		"Unable to load schema from '{0}': No content.",
		"Unable to parse content from '{0}': {1}.",
		"Unable to load schema from '{0}': {1}",
		"$ref '{0}' in {1} can not be resolved.",
		"Problems loading reference '{0}': {1}"
	],
	"vs/languages/json/common/parser/jsonParser": [
		"Incorrect type. Expected one of {0}",
		"Incorrect type. Expected \"{0}\"",
		"Matches a schema that is not allowed.",
		"Matches multiple schemas when only one must validate.",
		"Value is not an accepted value. Valid values: {0}",
		"Array has too many items according to schema. Expected {0} or fewer",
		"Array has too few items. Expected {0} or more",
		"Array has too many items. Expected {0} or fewer",
		"Array has duplicate items",
		"Value is not divisible by {0}",
		"Value is below the exclusive minimum of {0}",
		"Value is below the minimum of {0}",
		"Value is above the exclusive maximum of {0}",
		"Value is above the maximum of {0}",
		"String is shorter than the minimum length of ",
		"String is shorter than the maximum length of ",
		"String does not match the pattern of \"{0}\"",
		"Missing property \"{0}\"",
		"Property {0} is not allowed",
		"Object has more properties than limit of {0}",
		"Object has fewer properties than the required number of {0}",
		"Object is missing property {0} required by property {1}",
		"Invalid unicode sequence in string",
		"Invalid escape character in string",
		"Unexpected end of number",
		"Unexpected end of comment",
		"Unexpected end of string",
		"Value expected",
		"Expected comma or closing bracket",
		"Property keys must be doublequoted",
		"Duplicate object key",
		"Colon expected",
		"Value expected",
		"Property expected",
		"Expected comma or closing brace",
		"Invalid number format",
		"Invalid number format",
		"Expected a JSON object, array or literal",
		"End of file expected"
	]
});