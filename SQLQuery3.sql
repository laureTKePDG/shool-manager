drop database if exists bd_academie;

create database if not exists bd_academie;
# -----------------------------------------------------------------------------
#       table : matiere
# -----------------------------------------------------------------------------

create table if not exists matiere
 (
   code_mat char(32) not null  ,
   code_salle varchar(128) not null  ,
   intitule_mat varchar(128) not null  ,
   vh_mat integer(2) not null  ,
   credit_mat integer(2) not null  
   , primary key (code_mat) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       table : etudiant
# -----------------------------------------------------------------------------

create table if not exists etudiant
 (
   code_etud char(32) not null  ,
   nom_etud varchar(128) not null  ,
   penom_etud varchar(128) null  ,
   tel_etud varchar(128) not null  ,
   mail_etud varchar(128) not null  ,
   annee_etud integer(2) not null  
   , primary key (code_etud) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       table : departement
# -----------------------------------------------------------------------------

create table if not exists departement
 (
   label_dept char(32) not null  ,
   code_ens char(32) not null  ,
   site varchar(128) not null  
   , primary key (label_dept) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       table : academie
# -----------------------------------------------------------------------------

create table if not exists academie
 (
   label_aca char(32) not null  ,
   desc_aca text not null  
   , primary key (label_aca) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       table : salle
# -----------------------------------------------------------------------------

create table if not exists salle
 (
   code_salle varchar(128) not null  ,
   nb_place integer(2) not null  
   , primary key (code_salle) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       table : enseignant
# -----------------------------------------------------------------------------

create table if not exists enseignant
 (
   code_ens char(32) not null  ,
   code_mat char(32) not null  ,
   label_dept char(32) not null  ,
   nom_ens varchar(128) not null  ,
   prenom_ens varchar(128) null  ,
   tel_ens varchar(128) not null  ,
   mail_ens varchar(128) not null  ,
   date_fonction date not null  ,
   indice_ens integer(2) not null  
   , primary key (code_ens) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       table : college
# -----------------------------------------------------------------------------

create table if not exists college
 (
   site varchar(128) not null  ,
   label_aca char(32) not null  ,
   label_col varchar(128) not null  
   , primary key (site) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       table : evaluation
# -----------------------------------------------------------------------------

create table if not exists evaluation
 (
   code_etud char(32) not null  ,
   code_mat char(32) not null  ,
   note real(5,2) null  
   , primary key (code_etud,code_mat) 
 ) 
 comment = "";


# -----------------------------------------------------------------------------
#       creation des references de table
# -----------------------------------------------------------------------------


alter table matiere 
  add foreign key fk_matiere_salle (code_salle)
      references salle (code_salle) ;


alter table departement 
  add foreign key fk_departement_enseignant (code_ens)
      references enseignant (code_ens) ;


alter table departement 
  add foreign key fk_departement_college (site)
      references college (site) ;


alter table enseignant 
  add foreign key fk_enseignant_matiere (code_mat)
      references matiere (code_mat) ;


alter table enseignant 
  add foreign key fk_enseignant_departement (label_dept)
      references departement (label_dept) ;


alter table college 
  add foreign key fk_college_academie (label_aca)
      references academie (label_aca) ;


alter table evaluation 
  add foreign key fk_evaluation_etudiant (code_etud)
      references etudiant (code_etud) ;


alter table evaluation 
  add foreign key fk_evaluation_matiere (code_mat)
      references matiere (code_mat) ;

