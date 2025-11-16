using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000192 RID: 402
	[Serializable]
	public sealed class ExtraMerchantConditionData : ValueType
	{
		// Token: 0x06002B48 RID: 11080 RVA: 0x0012E230 File Offset: 0x0012C430
		// Note: this type is marked as 'beforefieldinit'.
		static ExtraMerchantConditionData()
		{
			Il2CppClassPointerStore<ExtraMerchantConditionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "ExtraMerchantConditionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtraMerchantConditionData>.NativeClassPtr);
			ExtraMerchantConditionData.NativeFieldInfoPtr_merchantKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtraMerchantConditionData>.NativeClassPtr, "merchantKey");
			ExtraMerchantConditionData.NativeFieldInfoPtr_merchantType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtraMerchantConditionData>.NativeClassPtr, "merchantType");
			ExtraMerchantConditionData.NativeFieldInfoPtr_eventKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtraMerchantConditionData>.NativeClassPtr, "eventKey");
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x00019342 File Offset: 0x00017542
		public ExtraMerchantConditionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x0001934B File Offset: 0x0001754B
		public ExtraMerchantConditionData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtraMerchantConditionData>.NativeClassPtr))
		{
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06002B4B RID: 11083 RVA: 0x0012E29C File Offset: 0x0012C49C
		// (set) Token: 0x06002B4C RID: 11084 RVA: 0x0001935D File Offset: 0x0001755D
		public unsafe string merchantKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtraMerchantConditionData.NativeFieldInfoPtr_merchantKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtraMerchantConditionData.NativeFieldInfoPtr_merchantKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06002B4D RID: 11085 RVA: 0x0012E2C4 File Offset: 0x0012C4C4
		// (set) Token: 0x06002B4E RID: 11086 RVA: 0x0001937C File Offset: 0x0001757C
		public unsafe ExtraMerchantConditionData.ConditionType merchantType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtraMerchantConditionData.NativeFieldInfoPtr_merchantType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtraMerchantConditionData.NativeFieldInfoPtr_merchantType)) = value;
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06002B4F RID: 11087 RVA: 0x0012E2EC File Offset: 0x0012C4EC
		// (set) Token: 0x06002B50 RID: 11088 RVA: 0x00019397 File Offset: 0x00017597
		public unsafe string eventKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtraMerchantConditionData.NativeFieldInfoPtr_eventKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtraMerchantConditionData.NativeFieldInfoPtr_eventKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001CA0 RID: 7328
		private static readonly IntPtr NativeFieldInfoPtr_merchantKey;

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeFieldInfoPtr_merchantType;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeFieldInfoPtr_eventKey;

		// Token: 0x020007C5 RID: 1989
		public enum ConditionType
		{
			// Token: 0x04006B30 RID: 27440
			FinishEvent,
			// Token: 0x04006B31 RID: 27441
			FinishMission
		}
	}
}
