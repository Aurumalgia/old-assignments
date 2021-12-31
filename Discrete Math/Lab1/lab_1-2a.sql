-- Program name: lab_1-2a.sql
-- Author: Kha Pham
-- Date: September 6, 2020

CREATE TEMP TABLE IF NOT EXISTS names (val TEXT);
CREATE TEMP TABLE IF NOT EXISTS years (val INT);
CREATE TEMP TABLE IF NOT EXISTS monthDays (val TEXT);
INSERT OR REPLACE INTO names VALUES ('Kha');
INSERT OR REPLACE INTO years VALUES (2020);
INSERT OR REPLACE INTO monthDays VALUES ('September 9');

-- note that CHAR(9) is tab and CHAR(10) is newline... see http://www.asciitable.com

SELECT CHAR(10) || CHAR(9) || "My name is " || n.val || "."|| CHAR(10) || CHAR(9) || "The date is " || m.val || ", " || y.val || CHAR(10)FROM names n, monthDays m, years y;

--Lines 5, 6, and 7 create temporary tables if those tables don't exist, and initialize them.
--Line 8-10 Insert or replace the value into those tables
--Line 14 selects and outputs a concatenation of a bunch of things, with tabs, newlines, and the values from the table.