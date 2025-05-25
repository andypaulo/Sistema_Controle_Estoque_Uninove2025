CREATE OR REPLACE TRIGGER trg_categorias_bi
BEFORE INSERT ON categorias
FOR EACH ROW
WHEN (NEW.id_categoria IS NULL)
BEGIN
  SELECT seq_categorias.NEXTVAL INTO :NEW.id_categoria FROM dual;
END;