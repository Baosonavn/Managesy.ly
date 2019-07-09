namespace DataCore
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using CoreTypes;

    public class CoreModel : DbContext
    {
        public CoreModel()
            : base("name=CoreModel")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Customer> Companies { get; set; }

        public virtual DbSet<BusinessField> BusinessFields { get; set; }

        public virtual DbSet<Bank> Banks { get; set; }

        public virtual DbSet<BankAccount> BankAccounts { get; set; }

        public virtual DbSet<Education> Educations { get; set; }

        public virtual DbSet<Experience> Experiences { get; set; }

        public virtual DbSet<JobTitle> JobTitles { get; set; }

        public virtual DbSet<LicenseType> LicenseTypes { get; set; }

        public virtual DbSet<License> Licenses { get; set; }

        public virtual DbSet<ProjectCategory> ProjectCategories { get; set; }

        public virtual DbSet<Project> Projects { get; set; }

        public virtual DbSet<TaskList> TaskLists { get; set; }

        public virtual DbSet<Board> Boards { get; set; }

        public virtual DbSet<BoardColumn> BoardColumns { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //User
            #region DEFINING PRIMARY KEYS

            modelBuilder.Entity<User>()
                   .HasKey(u => new { u.Id, u.Guid });

            modelBuilder.Entity<Department>()
                .HasKey(department => new { department.Id, department.Guid });

            modelBuilder.Entity<BankAccount>()
                .HasKey(bankAccount => new { bankAccount.Id, bankAccount.Guid });

            modelBuilder.Entity<Bank>()
                .HasKey(bank => new { bank.Id, bank.Guid });

            modelBuilder.Entity<Education>()
                .HasKey(education => new { education.Id, education.Guid });

            modelBuilder.Entity<BusinessField>()
                .HasKey(entity => new { entity.Id, entity.Guid });

            modelBuilder.Entity<Customer>()
                .HasKey(entity => new { entity.Id, entity.Guid });

            modelBuilder.Entity<Experience>()
                .HasKey(entity => new { entity.Id, entity.Guid });

            modelBuilder.Entity<JobTitle>()
               .HasKey(entity => new { entity.Id, entity.Guid });

            modelBuilder.Entity<LicenseType>()
               .HasKey(entity => new { entity.Id, entity.Guid });

            modelBuilder.Entity<License>()
               .HasKey(entity => new { entity.Id, entity.Guid });

            modelBuilder.Entity<ProjectCategory>()
              .HasKey(entity => new { entity.Id, entity.Guid });

            modelBuilder.Entity<Project>()
                .HasKey(entity => new { entity.Id, entity.Guid });

            modelBuilder.Entity<TaskList>()
                .HasKey(entity => new { entity.Id, entity.Guid });

            modelBuilder.Entity<Board>()
                .HasKey(entity => new { entity.Id, entity.Guid });

            modelBuilder.Entity<BoardColumn>()
                .HasKey(entity => new { entity.Id, entity.Guid });
            #endregion

            //An user must belong to a department
            modelBuilder.Entity<User>()
                .HasRequired(user => user.Department)
                .WithMany(dept => dept.Users)
                .HasForeignKey(user => new { user.DepartmentId, user.DepartmentGuid })
                .WillCascadeOnDelete(false);

            //An user may be assigned to many projects
            //A project may be assigned to many users
            modelBuilder.Entity<User>()
                .HasMany(user => user.AssignedProjects)
                .WithMany(project => project.AssignedUsers)
                .Map(map =>
                {
                    map.MapLeftKey("UserID");
                    map.MapRightKey("ProjectID");
                    map.ToTable("Assigned_Users_Projects");
                });

            #region BOARDS

            //A BOARDS can have an user creator
            modelBuilder.Entity<Board>()
                .HasOptional(board => board.CreatedByUser)
                .WithMany()
                .HasForeignKey(board => new { board.CreatedByUserId, board.CreatedByUserGuid })
                .WillCascadeOnDelete(false);

            //A BOARDS can have an user moderator
            modelBuilder.Entity<Board>()
                .HasOptional(board => board.ModifiedByUser)
                .WithMany()
                .HasForeignKey(board => new { board.ModifiedByUserId, board.ModifiedByUserGuid })
                .WillCascadeOnDelete(false);


            #endregion

            #region BOARD COLUMN
            //A column can have an user creator
            modelBuilder.Entity<BoardColumn>()
                .HasOptional(bCol => bCol.CreatedByUser)
                .WithMany()
                .HasForeignKey(bCol => new { bCol.CreatedByUserId, bCol.CreatedByUserGuid })
                .WillCascadeOnDelete(false);

            //A column can have an user moderator
            modelBuilder.Entity<BoardColumn>()
                .HasOptional(bCol => bCol.ModifiedByUser)
                .WithMany()
                .HasForeignKey(bCol => new { bCol.ModifiedByUserId, bCol.ModifiedByUserGuid })
                .WillCascadeOnDelete(false);

            //A boad column must belong to a board
            modelBuilder.Entity<BoardColumn>()
                .HasRequired(bCol => bCol.Board)
                .WithMany(board => board.BoardColumns)
                .HasForeignKey(bCol => new { bCol.BoardId, bCol.BoardGuid })
                .WillCascadeOnDelete(false);
            #endregion

            #region PROJECT CATEGORY

            //A project category can have an user creator
            modelBuilder.Entity<ProjectCategory>()
                .HasOptional(catg => catg.CreatedByUser)
                .WithMany()
                .HasForeignKey(catg => new { catg.CreatedByUserId, catg.CreatedByUserGuid })
                .WillCascadeOnDelete(false);

            //A project category can have an user moderator
            modelBuilder.Entity<ProjectCategory>()
                .HasOptional(catg => catg.ModifiedByUser)
                .WithMany()
                .HasForeignKey(catg => new { catg.ModifiedByUserId, catg.ModifiedByUserGuid })
                .WillCascadeOnDelete(false);

            //A category can have many sub category
            modelBuilder.Entity<ProjectCategory>()
                .HasOptional(catg => catg.SuperCategory)
                .WithMany(catg => catg.SubCategories)
                .HasForeignKey(catg => new { catg.SuperCategoryId, catg.SuperCategoryGuid })
                .WillCascadeOnDelete(false);

            #endregion

            #region PROJECT

            //A project can have an user creator
            modelBuilder.Entity<Project>()
                .HasOptional(prj => prj.CreatedByUser)
                .WithMany()
                .HasForeignKey(prj => new { prj.CreatedByUserId, prj.CreatedByUserGuid })
                .WillCascadeOnDelete(false);

            //A project can have an user moderator
            modelBuilder.Entity<Project>()
                .HasOptional(prj => prj.ModifiedByUser)
                .WithMany()
                .HasForeignKey(prj => new { prj.ModifiedByUserId, prj.ModifiedByUserGuid })
                .WillCascadeOnDelete(false);

            //A project can belong to a category (or not).
            modelBuilder.Entity<Project>()
                .HasOptional(prj => prj.Category)
                .WithMany()
                .HasForeignKey(prj => new { prj.CategoryId, prj.CategoryGuid })
                .WillCascadeOnDelete(false);

            //A project can be for a customer
            modelBuilder.Entity<Project>()
                .HasOptional(prj => prj.Customer)
                .WithMany(customer => customer.Projects)
                .HasForeignKey(prj => new { prj.CustomerId, prj.CustomerGuid })
                .WillCascadeOnDelete(false);

            //A project must have an owner
            modelBuilder.Entity<Project>()
                .HasRequired(prj => prj.Owner)
                .WithMany()
                .HasForeignKey(prj => new { prj.OwnerId, prj.OwnerGuid })
                .WillCascadeOnDelete(false);

            //A project may be in a column
            modelBuilder.Entity<Project>()
                .HasOptional(prj => prj.BoardColumn)
                .WithMany(bcol => bcol.Projects)
                .HasForeignKey(prj => new { prj.BoardColumnId, prj.BoardColumnGuid })
                .WillCascadeOnDelete(false);

            #endregion

            #region DEPARTMENTS


            //A department can have an user creator
            modelBuilder.Entity<Department>()
                .HasOptional(dept => dept.CreatedByUser)
                .WithMany()
                .HasForeignKey(dept => new { dept.CreatedByUserId, dept.CreatedByUserGuid })
                .WillCascadeOnDelete(false);

            //A department can have an user moderator
            modelBuilder.Entity<Department>()
                .HasOptional(dept => dept.ModifiedByUser)
                .WithMany()
                .HasForeignKey(dept => new { dept.ModifiedByUserId, dept.ModifiedByUserGuid })
                .WillCascadeOnDelete(false);

            //A Department can have sub departments
            modelBuilder.Entity<Department>()
                .HasOptional(dept => dept.ParentDepartment)
                .WithMany(dept => dept.ChildDepartments)
                .HasForeignKey(dept => new { dept.ParentDepartmentId, dept.ParentDepartmentGuid })
                .WillCascadeOnDelete(false);

            //A department can have a head user
            modelBuilder.Entity<Department>()
                .HasOptional(d => d.HeadUser)
                .WithMany()
                .HasForeignKey(d => new { d.HeadUserId, d.HeadUserGuid })
                .WillCascadeOnDelete(false);

            //A department can have a vice head user
            modelBuilder.Entity<Department>()
                .HasOptional(d => d.ViceUser)
                .WithMany()
                .HasForeignKey(d => new { d.ViceHeadUserId, d.ViceHeadUserGuid })
                .WillCascadeOnDelete(false);

            #endregion

            #region BANK ACCOUNT
            //A bank account can have a company as owner
            modelBuilder.Entity<BankAccount>()
                .HasOptional(b => b.Company)
                .WithMany(c => c.BankAccounts)
                .HasForeignKey(b => new { b.CompanyId, b.CompanyGuid })
                .WillCascadeOnDelete(false);

            //A bank account can have an user as owner
            modelBuilder.Entity<BankAccount>()
                .HasOptional(b => b.User)
                .WithMany(user => user.BankAccounts)
                .HasForeignKey(b => new { b.UserId, b.UserGuid })
                .WillCascadeOnDelete(false);

            //A bank account must have a bank
            modelBuilder.Entity<BankAccount>()
                .HasRequired(bAcc => bAcc.Bank)
                .WithMany()
                .HasForeignKey(bAcc => new { bAcc.BankId, bAcc.BankGuid })
                .WillCascadeOnDelete(false);

            //Creator
            modelBuilder.Entity<BankAccount>()
                .HasOptional(bacc => bacc.CreatedByUser)
                .WithMany()
                .HasForeignKey(bacc => new { bacc.CreatedByUserId, bacc.CreatedByUserGuid })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BankAccount>()
               .HasOptional(bacc => bacc.ModifiedByUser)
               .WithMany()
               .HasForeignKey(bacc => new { bacc.ModifiedByUserId, bacc.ModifiedByUserGuid })
               .WillCascadeOnDelete(false);

            #endregion

            #region BANK

            modelBuilder.Entity<Bank>()
               .HasOptional(b => b.CreatedByUser)
               .WithMany()
               .HasForeignKey(b => new { b.CreatedByUserId, b.CreatedByUserGuid })
               .WillCascadeOnDelete(false);


            modelBuilder.Entity<Bank>()
             .HasOptional(b => b.ModifiedByUser)
             .WithMany()
             .HasForeignKey(b => new { b.ModifiedByUserId, b.ModifiedByUserGuid })
             .WillCascadeOnDelete(false);

            #endregion

            #region EDUCATION

            modelBuilder.Entity<Education>()
              .HasOptional(education => education.User)
              .WithMany(user => user.Educations)
              .HasForeignKey(education => new { education.UserId, education.UserGuid })
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Education>()
            .HasOptional(education => education.CreatedByUser)
            .WithMany()
            .HasForeignKey(education => new { education.CreatedByUserId, education.CreatedByUserGuid })
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<Education>()
             .HasOptional(education => education.ModifiedByUser)
             .WithMany()
             .HasForeignKey(education => new { education.ModifiedByUserId, education.ModifiedByUserGuid })
             .WillCascadeOnDelete(false);

            #endregion

            #region BUSINESS FIELDS

            modelBuilder.Entity<BusinessField>()
                .HasOptional(field => field.CreatedByUser)
                .WithMany()
                .HasForeignKey(field => new { field.CreatedByUserId, field.CreatedByUserGuid })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessField>()
                .HasOptional(field => field.ModifiedByUser)
                .WithMany()
                .HasForeignKey(field => new { field.ModifiedByUserId, field.ModifiedByUserGuid })
                .WillCascadeOnDelete(false);

            #endregion

            #region COMPANY

            modelBuilder.Entity<Customer>()
                .HasOptional(company => company.CreatedByUser)
                .WithMany()
                .HasForeignKey(company => new { company.CreatedByUserId, company.CreatedByUserGuid })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessField>()
                .HasOptional(company => company.ModifiedByUser)
                .WithMany()
                .HasForeignKey(company => new { company.ModifiedByUserId, company.ModifiedByUserGuid })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(company => company.BusinessFields)
                .WithMany(field => field.Companies)
                .Map(cf =>
                {
                    cf.MapLeftKey("CompanyId");
                    cf.MapRightKey("BusinessFieldId");
                    cf.ToTable("CompaniesBusinessFields");
                });

            modelBuilder.Entity<Customer>()
                .HasMany(company => company.Customers)
                .WithMany()
                .Map(cc =>
                {
                    cc.MapLeftKey("CompanyId");
                    cc.MapRightKey("CustomerId");
                    cc.ToTable("Companies_Customers");
                });

            #endregion

            #region EXPERIENCES

            modelBuilder.Entity<Experience>()
             .HasOptional(exp => exp.User)
             .WithMany(user => user.Experiences)
             .HasForeignKey(exp => new { exp.UserId, exp.UserGuid })
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<Experience>()
            .HasOptional(exp => exp.CreatedByUser)
            .WithMany()
            .HasForeignKey(exp => new { exp.CreatedByUserId, exp.CreatedByUserGuid })
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<Experience>()
             .HasOptional(exp => exp.ModifiedByUser)
             .WithMany()
             .HasForeignKey(exp => new { exp.ModifiedByUserId, exp.ModifiedByUserGuid })
             .WillCascadeOnDelete(false);

            #endregion

            #region JOBTITLES

            modelBuilder.Entity<JobTitle>()
                .HasMany(job => job.Users)
                .WithMany(user => user.JobTitles)
                .Map(map =>
                {
                    map.MapLeftKey("JobTitleId");
                    map.MapRightKey("UserId");
                    map.ToTable("JobTitles_Users");
                });

            modelBuilder.Entity<JobTitle>()
            .HasOptional(job => job.CreatedByUser)
            .WithMany()
            .HasForeignKey(job => new { job.CreatedByUserId, job.CreatedByUserGuid })
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobTitle>()
             .HasOptional(job => job.ModifiedByUser)
             .WithMany()
             .HasForeignKey(job => new { job.ModifiedByUserId, job.ModifiedByUserGuid })
             .WillCascadeOnDelete(false);


            #endregion

            #region LICENSE TYPES

            modelBuilder.Entity<LicenseType>()
           .HasOptional(lictype => lictype.CreatedByUser)
           .WithMany()
           .HasForeignKey(licType => new { licType.CreatedByUserId, licType.CreatedByUserGuid })
           .WillCascadeOnDelete(false);

            modelBuilder.Entity<LicenseType>()
             .HasOptional(licType => licType.ModifiedByUser)
             .WithMany()
             .HasForeignKey(licType => new { licType.ModifiedByUserId, licType.ModifiedByUserGuid })
             .WillCascadeOnDelete(false);



            #endregion

            #region LICENSE
            modelBuilder.Entity<License>()
                .HasOptional(lic => lic.CreatedByUser)
                .WithMany()
                .HasForeignKey(lic => new { lic.CreatedByUserId, lic.CreatedByUserGuid })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<License>()
             .HasOptional(lic => lic.ModifiedByUser)
             .WithMany()
             .HasForeignKey(lic => new { lic.ModifiedByUserId, lic.ModifiedByUserGuid })
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<License>()
                .HasRequired(lic => lic.LicenseType)
                .WithMany(licType => licType.Licenses)
                .HasForeignKey(lic => new { lic.LicenseTypeId, lic.LicenseTypeGuid })
                .WillCascadeOnDelete(false);

            #endregion
        }
    }


}