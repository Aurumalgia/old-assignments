DROP TABLE IF EXISTS asciiTable;
DROP TABLE IF EXISTS count;
CREATE TEMPORARY TABLE asciiTable(decN, binN, octN, hexN, asciiChar);
CREATE TEMPORARY TABLE count(x);

WITH RECURSIVE cnt(x) AS (SELECT 0 UNION ALL SELECT x+1 FROM cnt LIMIT 127)
INSERT INTO count SELECT * FROM cnt;


INSERT INTO asciiTable SELECT x, (SELECT   case (a>>7)&1 when 1 then '1' else '0' end ||
                                case (a>>6)&1 when 1 then '1' else '0' end ||
                                case (a>>5)&1 when 1 then '1' else '0' end ||
                                case (a>>4)&1 when 1 then '1' else '0' end ||
                                case (a>>3)&1 when 1 then '1' else '0' end ||
                                case (a>>2)&1 when 1 then '1' else '0' end ||
                                case (a>>1)&1 when 1 then '1' else '0' end ||
                                case (a>>0)&1 when 1 then '1' else '0' end
                                from (select x as a)), printf("%.3o", x), HEX(char(x)), char(x) FROM count;
SELECT * FROM asciiTable;