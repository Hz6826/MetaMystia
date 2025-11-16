using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000191 RID: 401
	[Serializable]
	public sealed class ExtraMerchantData : ValueType
	{
		// Token: 0x06002B3D RID: 11069 RVA: 0x0012E110 File Offset: 0x0012C310
		// Note: this type is marked as 'beforefieldinit'.
		static ExtraMerchantData()
		{
			Il2CppClassPointerStore<ExtraMerchantData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "ExtraMerchantData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtraMerchantData>.NativeClassPtr);
			ExtraMerchantData.NativeFieldInfoPtr_merchantKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtraMerchantData>.NativeClassPtr, "merchantKey");
			ExtraMerchantData.NativeFieldInfoPtr_merchantMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtraMerchantData>.NativeClassPtr, "merchantMapLabel");
			ExtraMerchantData.NativeFieldInfoPtr_merchantType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtraMerchantData>.NativeClassPtr, "merchantType");
			ExtraMerchantData.NativeFieldInfoPtr_collabKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtraMerchantData>.NativeClassPtr, "collabKey");
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x000192AF File Offset: 0x000174AF
		public ExtraMerchantData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x000192B8 File Offset: 0x000174B8
		public ExtraMerchantData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtraMerchantData>.NativeClassPtr))
		{
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06002B40 RID: 11072 RVA: 0x0012E190 File Offset: 0x0012C390
		// (set) Token: 0x06002B41 RID: 11073 RVA: 0x000192CA File Offset: 0x000174CA
		public unsafe string merchantKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtraMerchantData.NativeFieldInfoPtr_merchantKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtraMerchantData.NativeFieldInfoPtr_merchantKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06002B42 RID: 11074 RVA: 0x0012E1B8 File Offset: 0x0012C3B8
		// (set) Token: 0x06002B43 RID: 11075 RVA: 0x000192E9 File Offset: 0x000174E9
		public unsafe string merchantMapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtraMerchantData.NativeFieldInfoPtr_merchantMapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtraMerchantData.NativeFieldInfoPtr_merchantMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x0012E1E0 File Offset: 0x0012C3E0
		// (set) Token: 0x06002B45 RID: 11077 RVA: 0x00019308 File Offset: 0x00017508
		public unsafe ExtraMerchantData.MerchantType merchantType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtraMerchantData.NativeFieldInfoPtr_merchantType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtraMerchantData.NativeFieldInfoPtr_merchantType)) = value;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x0012E208 File Offset: 0x0012C408
		// (set) Token: 0x06002B47 RID: 11079 RVA: 0x00019323 File Offset: 0x00017523
		public unsafe string collabKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtraMerchantData.NativeFieldInfoPtr_collabKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtraMerchantData.NativeFieldInfoPtr_collabKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001C9C RID: 7324
		private static readonly IntPtr NativeFieldInfoPtr_merchantKey;

		// Token: 0x04001C9D RID: 7325
		private static readonly IntPtr NativeFieldInfoPtr_merchantMapLabel;

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeFieldInfoPtr_merchantType;

		// Token: 0x04001C9F RID: 7327
		private static readonly IntPtr NativeFieldInfoPtr_collabKey;

		// Token: 0x020007C4 RID: 1988
		public enum MerchantType
		{
			// Token: 0x04006B2D RID: 27437
			AlwaysOpen,
			// Token: 0x04006B2E RID: 27438
			Collab
		}
	}
}
