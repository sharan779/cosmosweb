/*!-----------------------------------------------------------
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Version: 0.5.2(d49899a916fd99840f6f9178f2dd06e0e7013646)
 * Released under the MIT license
 * https://github.com/Microsoft/vscode/blob/master/LICENSE.txt
 *-----------------------------------------------------------*/

define("vs/languages/json/common/jsonWorker.nls.fr", {
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
		"Bower par défaut.json",
		"Échec de la requête destinée au référentiel bower : {0}",
		"Échec de la requête destinée au référentiel bower : {0}",
		"{0}",
	],
	"vs/languages/json/common/contributions/globPatternContribution": [
		"Fichiers par extension",
		"Faites correspondre tous les fichiers ayant une extension de fichier spécifique.",
		"Fichiers avec plusieurs extensions",
		"Faites correspondre tous les fichiers, indépendamment de leurs extensions.",
		"Fichiers avec frères par nom",
		"Faites correspondre les fichiers ayant des frères portant le même nom mais avec une extension distincte.",
		"Dossier par nom (premier niveau)",
		"Faites correspondre un dossier de premier niveau.",
		"Dossiers avec plusieurs noms (premier niveau)",
		"Faites correspondre plusieurs dossiers de premier niveau.",
		"Dossier par nom (tous les emplacements)",
		"Faites correspondre un dossier ayant un nom spécifique, indépendamment de son emplacement.",
		"Vrai",
		"Activez le modèle.",
		"Faux",
		"Désactivez le modèle.",
		"Fichiers avec frères par nom",
		"Faites correspondre les fichiers ayant des frères portant le même nom mais avec une extension distincte.",
	],
	"vs/languages/json/common/contributions/packageJSONContribution": [
		"Fichier package.json par défaut",
		"Échec de la requête destinée au référentiel NPM : {0}",
		"Échec de la requête destinée au référentiel NPM : {0}",
		"Dernière version du package",
		"Correspond à la version majeure la plus récente (1.x.x)",
		"Correspond à la version mineure la plus récente (1.2.x)",
		"{0}",
		"Dernière version : {0}",
	],
	"vs/languages/json/common/contributions/projectJSONContribution": [
		"Projet par défaut.json",
		"Échec de la requête destinée au référentiel nuget : {0}",
		"Échec de la requête destinée au référentiel nuget : {0}",
		"Dernière version du package",
		"{0}",
		"Dernière version : {0}",
	],
	"vs/languages/json/common/jsonIntellisense": [
		"Valeur par défaut",
	],
	"vs/languages/json/common/jsonSchemaService": [
		"Unable to load schema from \'{0}\': No content.",
		"Unable to parse content from \'{0}\': {1}.",
		"Impossible de charger le schéma depuis \'{0}\' : {1}.",
		"$ref \'{0}\' in {1} can not be resolved.",
		"Problems loading reference \'{0}\': {1}",
	],
	"vs/languages/json/common/parser/jsonParser": [
		"Type incorrect. {0} était attendu.",
		"Type incorrect. \"{0}\" était attendu",
		"Correspond à un schéma non autorisé.",
		"Correspond à plusieurs schémas alors qu\'un seul doit exister pour la validation.",
		"La valeur n\'est pas acceptée. Valeurs valides : {0}",
		"Le tableau comporte trop d\'éléments selon le schéma. {0} maximum sont attendus",
		"Le tableau ne contient pas assez d\'éléments. {0} minimum sont attendus",
		"Le tableau contient trop d\'éléments. {0} éléments au maximum sont attendus",
		"Le tableau comporte des doublons",
		"La valeur n\'est pas divisible par {0}",
		"La valeur est inférieur au minimum exclusif {0}",
		"La valeur est inférieure au minimum {0}",
		"La valeur est supérieure au maximum exclusif {0}",
		"La valeur est supérieure au maximum {0}",
		"La chaîne est plus courte que la longueur minimum",
		"La chaîne est plus courte que la longueur maximum",
		"La chaîne ne correspond pas au modèle \"{0}\"",
		"Propriété manquante \"{0}\"",
		"La propriété {0} n\'est pas autorisée",
		"L\'objet a plus de propriétés que la limite {0}",
		"L\'objet a moins de propriétés que le nombre requis {0}",
		"La propriété {0} requise par la propriété {1} est manquante pour l\'objet",
		"Séquence unicode non valide dans la chaîne",
		"Caractère d\'échappement non valide dans la chaîne",
		"Fin de nombre inattendue",
		"Fin de commentaire inattendue",
		"Fin de chaîne inattendue",
		"Valeur attendue",
		"Virgule ou crochet fermant attendu",
		"Les clés de propriété doivent être entre guillemets doubles",
		"Clé d\'objet en double",
		"Signe des deux points attendu",
		"Valeur attendue",
		"Propriété attendue",
		"Virgule ou accolade fermante attendue",
		"Format de nombre non valide",
		"Format de nombre non valide",
		"Littéral, tableau ou objet JSON attendu",
		"Fin de fichier attendue",
	]
});