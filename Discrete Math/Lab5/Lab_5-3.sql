
DROP TABLE IF EXISTS tempBinTable;
CREATE TEMPORARY TABLE tempBinTable(dec, bin, oct);

WITH RECURSIVE binTable(dec, bin, oct)
    AS ( SELECT 0, '00000000', '000'
        UNION ALL
        SELECT dec+1, (SELECT   case (a>>7)&1 when 1 then '1' else '0' end ||
                                case (a>>6)&1 when 1 then '1' else '0' end ||
                                case (a>>5)&1 when 1 then '1' else '0' end ||
                                case (a>>4)&1 when 1 then '1' else '0' end ||
                                case (a>>3)&1 when 1 then '1' else '0' end ||
                                case (a>>2)&1 when 1 then '1' else '0' end ||
                                case (a>>1)&1 when 1 then '1' else '0' end ||
                                case (a>>0)&1 when 1 then '1' else '0' end
                                from (select dec+1 as a)), printf("%.3o", dec+1)

            FROM binTable
            LIMIT 128
        )
INSERT INTO tempBinTable SELECT * FROM binTable;


WITH RECURSIVE asciiTable(decN, hexN, octN, binN, asciiChar)
    AS
        (   SELECT 0, 0, '000', '00000000', char(0)
            UNION ALL
            SELECT decN+1, HEX(char(decN+1)), (SELECT oct FROM tempBinTable where dec = decN+1) ,(SELECT bin FROM tempBinTable where dec = decN+1), char(decN+1) FROM asciiTable
            LIMIT 128
            )
SELECT decN, octN, hexN, binN, asciiChar FROM asciiTable;


