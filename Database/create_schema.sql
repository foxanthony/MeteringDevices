ALTER DEFAULT PRIVILEGES IN SCHEMA "public" GRANT SELECT,INSERT,UPDATE,DELETE ON TABLES TO "ValuesUser";
GRANT USAGE, SELECT ON ALL SEQUENCES IN SCHEMA PUBLIC TO "ValuesUser";
CREATE TABLE "KznValues" (
    "Id" SERIAL PRIMARY KEY,
    "When" TIMESTAMP WITH TIME ZONE NOT NULL DEFAULT CURRENT_TIMESTAMP,
    "Day" INT NOT NULL,
    "Night" INT NOT NULL,
    "Hot" INT NOT NULL,
    "Cold" INT NOT NULL,
    "Kitchen" INT NOT NULL,
    "Room" INT NOT NULL,
    UNIQUE ("When")
);

CREATE VIEW "KznCurrentValues" (
    "When",
    "Day",
    "Night",
    "Hot",
    "Cold",
    "Kitchen",
    "Room"
) AS
WITH
    "Last" AS (SELECT "When", "Day", "Night", "Hot", "Cold", "Kitchen", "Room" FROM "KznValues" ORDER BY "When" DESC LIMIT 1),
    "PreLast" AS (SELECT "When", "Day", "Night", "Hot", "Cold", "Kitchen", "Room" FROM "KznValues" ORDER BY "When" DESC LIMIT 1 OFFSET 1),
    "Diff" AS (
	SELECT
	    EXTRACT(EPOCH FROM "Last"."When" - "PreLast"."When") AS "Interval",
	    EXTRACT(EPOCH FROM CURRENT_TIMESTAMP - "Last"."When") AS "CurrentInterval",
	    "Last"."Day" - "PreLast"."Day" AS "Day",
	    "Last"."Night" - "PreLast"."Night" AS "Night",
	    "Last"."Hot" - "PreLast"."Hot" AS "Hot",
	    "Last"."Cold" - "PreLast"."Cold" AS "Cold",
	    "Last"."Kitchen" - "PreLast"."Kitchen" AS "Kitchen",
	    "Last"."Room" - "PreLast"."Room" AS "Room"
	FROM
	    "Last"
	JOIN
	    "PreLast"
	ON
	    0 = 0
    )
SELECT
    CURRENT_TIMESTAMP AS "When",
    CAST(TRUNC("Last"."Day" + "Diff"."Day" / "Diff"."Interval" * "Diff"."CurrentInterval") AS INT) AS "Day",
    CAST(TRUNC("Last"."Night" + "Diff"."Night" / "Diff"."Interval" * "Diff"."CurrentInterval") AS INT) AS "Night",
    CAST(TRUNC("Last"."Hot" + "Diff"."Hot" / "Diff"."Interval" * "Diff"."CurrentInterval") AS INT) AS "Hot",
    CAST(TRUNC("Last"."Cold" + "Diff"."Cold" / "Diff"."Interval" * "Diff"."CurrentInterval") AS INT) AS "Cold",
    CAST(TRUNC("Last"."Kitchen" + "Diff"."Kitchen" / "Diff"."Interval" * "Diff"."CurrentInterval") AS INT) AS "Kitchen",
    CAST(TRUNC("Last"."Room" + "Diff"."Room" / "Diff"."Interval" * "Diff"."CurrentInterval") AS INT) AS "Room"
FROM
    "Last"
JOIN
    "Diff"
ON
    0 = 0;

CREATE TABLE "SpbValues" (
    "Id" SERIAL PRIMARY KEY,
    "When" TIMESTAMP WITH TIME ZONE NOT NULL DEFAULT CURRENT_TIMESTAMP,
    "Day" INT NOT NULL,
    "Night" INT NOT NULL,
    "KitchenCold" INT NOT NULL,
    "KitchenHot" INT NOT NULL,
    "BathroomCold" INT NOT NULL,
    "BathroomHot" INT NOT NULL,
    UNIQUE ("When")
);

CREATE VIEW "SpbCurrentValues" (
    "When",
    "Day",
    "Night"
) AS
WITH
    "Last" AS (SELECT "When", "Day", "Night", "KitchenCold", "KitchenHot", "BathroomCold", "BathroomHot" FROM "SpbValues" ORDER BY "When" DESC LIMIT 1),
    "PreLast" AS (SELECT "When", "Day", "Night", "KitchenCold", "KitchenHot", "BathroomCold", "BathroomHot" FROM "SpbValues" ORDER BY "When" DESC LIMIT 1 OFFSET 1),
    "Diff" AS (
	SELECT
	    EXTRACT(EPOCH FROM "Last"."When" - "PreLast"."When") AS "Interval",
	    EXTRACT(EPOCH FROM CURRENT_TIMESTAMP - "Last"."When") AS "CurrentInterval",
	    "Last"."Day" - "PreLast"."Day" AS "Day",
	    "Last"."Night" - "PreLast"."Night" AS "Night",
	    "Last"."KitchenCold" - "PreLast"."KitchenCold" AS "KitchenCold",
	    "Last"."KitchenHot" - "PreLast"."KitchenHot" AS "KitchenHot",
	    "Last"."BathroomCold" - "PreLast"."BathroomCold" AS "BathroomCold",
	    "Last"."BathroomHot" - "PreLast"."BathroomHot" AS "BathroomHot"
	FROM
	    "Last"
	JOIN
	    "PreLast"
	ON
	    0 = 0
    )
SELECT
    CURRENT_TIMESTAMP AS "When",
    CAST(TRUNC("Last"."Day" + "Diff"."Day" / "Diff"."Interval" * "Diff"."CurrentInterval") AS INT) AS "Day",
    CAST(TRUNC("Last"."Night" + "Diff"."Night" / "Diff"."Interval" * "Diff"."CurrentInterval") AS INT) AS "Night",
    CAST(TRUNC("Last"."KitchenCold" + "Diff"."KitchenCold" / "Diff"."Interval" * "Diff"."CurrentInterval") AS INT) AS "KitchenCold",
    CAST(TRUNC("Last"."KitchenHot" + "Diff"."KitchenHot" / "Diff"."Interval" * "Diff"."CurrentInterval") AS INT) AS "KitchenHot",
    CAST(TRUNC("Last"."BathroomCold" + "Diff"."BathroomCold" / "Diff"."Interval" * "Diff"."CurrentInterval") AS INT) AS "BathroomCold",
    CAST(TRUNC("Last"."BathroomHot" + "Diff"."BathroomHot" / "Diff"."Interval" * "Diff"."CurrentInterval") AS INT) AS "BathroomHot"
FROM
    "Last"
JOIN
    "Diff"
ON
    0 = 0;
