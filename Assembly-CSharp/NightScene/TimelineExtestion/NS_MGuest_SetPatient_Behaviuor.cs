using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001ED RID: 493
	public class NS_MGuest_SetPatient_Behaviuor : NormalPlayableBehaviour
	{
		// Token: 0x06003CAD RID: 15533 RVA: 0x0016C938 File Offset: 0x0016AB38
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_SetPatient_Behaviuor()
		{
			Il2CppClassPointerStore<NS_MGuest_SetPatient_Behaviuor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_SetPatient_Behaviuor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_SetPatient_Behaviuor>.NativeClassPtr);
			NS_MGuest_SetPatient_Behaviuor.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_SetPatient_Behaviuor>.NativeClassPtr, "label");
			NS_MGuest_SetPatient_Behaviuor.NativeFieldInfoPtr_targetPatient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_SetPatient_Behaviuor>.NativeClassPtr, "targetPatient");
			NS_MGuest_SetPatient_Behaviuor.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_SetPatient_Behaviuor>.NativeClassPtr, 100674516);
			NS_MGuest_SetPatient_Behaviuor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_SetPatient_Behaviuor>.NativeClassPtr, 100674517);
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x0016C9B8 File Offset: 0x0016ABB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136951, XrefRangeEnd = 136956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_SetPatient_Behaviuor.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x0016C9F4 File Offset: 0x0016ABF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_SetPatient_Behaviuor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_SetPatient_Behaviuor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_SetPatient_Behaviuor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CB0 RID: 15536 RVA: 0x0002204A File Offset: 0x0002024A
		public NS_MGuest_SetPatient_Behaviuor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06003CB1 RID: 15537 RVA: 0x0016CA30 File Offset: 0x0016AC30
		// (set) Token: 0x06003CB2 RID: 15538 RVA: 0x00022053 File Offset: 0x00020253
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_SetPatient_Behaviuor.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_SetPatient_Behaviuor.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06003CB3 RID: 15539 RVA: 0x0016CA58 File Offset: 0x0016AC58
		// (set) Token: 0x06003CB4 RID: 15540 RVA: 0x00022072 File Offset: 0x00020272
		public unsafe int targetPatient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_SetPatient_Behaviuor.NativeFieldInfoPtr_targetPatient);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_SetPatient_Behaviuor.NativeFieldInfoPtr_targetPatient)) = value;
			}
		}

		// Token: 0x040028AB RID: 10411
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040028AC RID: 10412
		private static readonly IntPtr NativeFieldInfoPtr_targetPatient;

		// Token: 0x040028AD RID: 10413
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028AE RID: 10414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
