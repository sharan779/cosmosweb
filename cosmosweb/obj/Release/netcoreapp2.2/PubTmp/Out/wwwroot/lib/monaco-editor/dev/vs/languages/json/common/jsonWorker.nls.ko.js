/*!-----------------------------------------------------------
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Version: 0.5.2(d49899a916fd99840f6f9178f2dd06e0e7013646)
 * Released under the MIT license
 * https://github.com/Microsoft/vscode/blob/master/LICENSE.txt
 *-----------------------------------------------------------*/

define("vs/languages/json/common/jsonWorker.nls.ko", {
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
		"HTTP status code {0}",
	],
	"vs/languages/json/common/contributions/bowerJSONContribution": [
		"Default bower.json",
		"Bower 리포지토리 요청 실패: {0}",
		"Bower 리포지토리 요청 실패: {0}",
		"{0}",
	],
	"vs/languages/json/common/contributions/globPatternContribution": [
		"확장명별 파일",
		"특정 파일 확장명의 모든 파일을 일치시킵니다.",
		"여러 확장명이 있는 파일",
		"모든 파일을 모든 파일 확장명과 일치시킵니다.",
		"이름별 형제가 있는 파일",
		"동일한 이름의 형제가 있지만 확장명이 다른 파일을 일치시킵니다.",
		"이름별 폴더(최상위 수준)",
		"최상위 폴더를 특정 이름과 일치시킵니다.",
		"여러 이름이 있는 폴더(최상위 수준)",
		"여러 최상위 폴더를 일치시킵니다.",
		"이름별 폴더(모든 위치)",
		"폴더를 모든 위치의 특정 이름과 일치시킵니다.",
		"True",
		"패턴을 사용하도록 설정합니다.",
		"False",
		"패턴을 사용하지 않도록 설정합니다.",
		"이름별 형제가 있는 파일",
		"동일한 이름의 형제가 있지만 확장명이 다른 파일을 일치시킵니다.",
	],
	"vs/languages/json/common/contributions/packageJSONContribution": [
		"기본 package.json",
		"NPM 리포지토리 요청 실패: {0}",
		"NPM 리포지토리 요청 실패: {0}",
		"패키지의 최신 버전",
		"최신 주 버전(1.x.x)을 일치시킵니다.",
		"최신 부 버전(1.2.x)을 일치시킵니다.",
		"{0}",
		"최신 버전: {0}",
	],
	"vs/languages/json/common/contributions/projectJSONContribution": [
		"Default project.json",
		"nuget 리포지토리 요청 실패: {0}",
		"nuget 리포지토리 요청 실패: {0}",
		"현재 패키지의 최신 버전",
		"{0}",
		"최신 버전: {0}",
	],
	"vs/languages/json/common/jsonIntellisense": [
		"기본값",
	],
	"vs/languages/json/common/jsonSchemaService": [
		"Unable to load schema from \'{0}\': No content.",
		"Unable to parse content from \'{0}\': {1}.",
		"\'{0}\'에서 스키마를 로드할 수 없습니다. {1}.",
		"$ref \'{0}\' in {1} can not be resolved.",
		"Problems loading reference \'{0}\': {1}",
	],
	"vs/languages/json/common/parser/jsonParser": [
		"형식이 잘못되었습니다. {0} 중 하나의 형식이어야 합니다.",
		"형식이 잘못되었습니다. \"{0}\"이어야 합니다.",
		"허용되지 않는 스키마와 일치합니다.",
		"하나의 스키마만 유효성 검사해야 하는데 여러 스키마와 일치합니다.",
		"값이 허용되지 않습니다. 유효한 값은 {0}입니다.",
		"스키마를 기준으로 배열에 항목이 너무 많습니다. {0}개 이하여야 합니다.",
		"배열에 항목이 너무 적습니다. {0}개 이상이어야 합니다.",
		"배열에 항목이 너무 많습니다. {0}개 이하여야 합니다.",
		"배열에 중복 항목이 있습니다.",
		"값을 {0}(으)로 나눌 수 없습니다.",
		"값이 배타적 최소값인 {0}보다 작습니다.",
		"값이 최소값인 {0}보다 작습니다.",
		"값이 배타적 최대값인 {0}보다 큽니다.",
		"값이 최대값인 {0}보다 큽니다.",
		"문자열이 다음 최소 길이보다 짧습니다. ",
		"문자열이 다음 최대 길이보다 짧습니다. ",
		"문자열이 \"{0}\" 패턴과 일치하지 않습니다.",
		"\"{0}\" 속성 누락",
		"{0} 속성이 허용되지 않습니다.",
		"개체의 속성이 제한인 {0}보다 많습니다.",
		"개체의 속성이 필요한 수인 {0}보다 적습니다.",
		"개체에 {1} 속성에 필요한 {0} 속성이 없습니다.",
		"문자열에 잘못된 유니코드 시퀀스가 있습니다.",
		"문자열에 잘못된 이스케이프 문자가 있습니다.",
		"필요하지 않은 번호 끝",
		"필요하지 않은 주석 끝",
		"필요하지 않은 문자열 끝",
		"값 필요",
		"쉼표 또는 닫는 대괄호 필요",
		"속성 키는 큰따옴표로 묶어야 합니다.",
		"중복된 개체 키",
		"콜론 필요",
		"값 필요",
		"속성 필요",
		"쉼표 또는 닫는 중괄호 필요",
		"잘못된 숫자 형식",
		"잘못된 숫자 형식",
		"JSON 개체, 배열 또는 리터럴 필요",
		"파일 끝 필요",
	]
});