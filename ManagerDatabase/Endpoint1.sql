﻿CREATE ENDPOINT [Endpoint1]
	AS TCP
	(
		LISTENER_PORT = 4022
	)
	FOR SERVICE_BROKER()
