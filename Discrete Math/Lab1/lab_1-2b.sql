-- Program name: lab_1-2b.sql
-- Author: Kha
-- Date: September 6, 2020
CREATE TEMP TABLE IF NOT EXISTS integers (val INT);
INSERT OR REPLACE INTO integers VALUES (255);
SELECT printf('%08X', val) FROM integers;
SELECT unicode(quote("A")); -- 'A' char is not a string "A"
SELECT unicode(quote("0")); --quote() is used for char literals
SELECT char(65);        -- conv to char
SELECT unicode('A');    -- conv to int
SELECT 1 > 2;           -- false denoted as 0; true denoted as 1
SELECT unicode(quote("A")) * unicode(quote("0"));
SELECT length("The character count in this line is...");