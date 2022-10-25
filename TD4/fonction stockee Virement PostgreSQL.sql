CREATE OR REPLACE FUNCTION sp_virement_append(pIdCompteDebit integer,
								 pIdCompteCredit integer,
								 pMontant numeric
								 )
RETURNS INTEGER
AS $$
DECLARE
	vNblignes INTEGER := 0;
	vRowcount INTEGER;
BEGIN
	UPDATE compte SET solde = solde-pMontant WHERE idcompte=pIdCompteDebit;
	GET DIAGNOSTICS vRowcount = ROW_COUNT; -- renvoie le nombre de lignes modifiées
	vNblignes:=vNblignes + vRowcount; 
	
	UPDATE compte SET solde = solde+pMontant WHERE idcompte=pIdCompteCredit;
	GET DIAGNOSTICS vRowcount = ROW_COUNT;
	vNblignes:=vNblignes + vRowcount;
	
	IF vNblignes=2 THEN
		INSERT INTO virement(idcomptedebit, idcomptecredit, datetransaction, montant)
			VALUES (pIdCompteDebit, pIdCompteCredit, current_date, pMontant);
		GET DIAGNOSTICS vRowcount = ROW_COUNT;
		vNblignes:=vNblignes + vRowcount;
	END IF;
	
	IF vNblignes<>3 THEN -- 2 UPDATE + 1 INSERT
		RAISE EXCEPTION 'Erreur';
	END IF;
		
	RETURN vNblignes;
END;
$$  LANGUAGE plpgsql

-- TEST
-- SELECT * FROM virement;
-- SELECT sp_virement_Append(1234567,2345678,100);
-- SELECT * FROM virement;