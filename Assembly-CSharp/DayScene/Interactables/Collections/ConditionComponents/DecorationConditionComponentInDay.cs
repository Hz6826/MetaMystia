using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x0200016C RID: 364
	public class DecorationConditionComponentInDay : EntityConditionComponent
	{
		// Token: 0x06002896 RID: 10390 RVA: 0x001257E0 File Offset: 0x001239E0
		// Note: this type is marked as 'beforefieldinit'.
		static DecorationConditionComponentInDay()
		{
			Il2CppClassPointerStore<DecorationConditionComponentInDay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionComponents", "DecorationConditionComponentInDay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorationConditionComponentInDay>.NativeClassPtr);
			DecorationConditionComponentInDay.NativeFieldInfoPtr_decorationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationConditionComponentInDay>.NativeClassPtr, "decorationId");
			DecorationConditionComponentInDay.NativeFieldInfoPtr_inverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationConditionComponentInDay>.NativeClassPtr, "inverse");
			DecorationConditionComponentInDay.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationConditionComponentInDay>.NativeClassPtr, 100670409);
			DecorationConditionComponentInDay.NativeMethodInfoPtr_Used_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationConditionComponentInDay>.NativeClassPtr, 100670410);
			DecorationConditionComponentInDay.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationConditionComponentInDay>.NativeClassPtr, 100670411);
			DecorationConditionComponentInDay.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationConditionComponentInDay>.NativeClassPtr, 100670412);
			DecorationConditionComponentInDay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationConditionComponentInDay>.NativeClassPtr, 100670413);
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x0012589C File Offset: 0x00123A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92376, XrefRangeEnd = 92385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnGetAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecorationConditionComponentInDay.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x001258E4 File Offset: 0x00123AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92385, XrefRangeEnd = 92394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Used()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationConditionComponentInDay.NativeMethodInfoPtr_Used_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x00125920 File Offset: 0x00123B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92394, XrefRangeEnd = 92400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetComponentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecorationConditionComponentInDay.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x0012596C File Offset: 0x00123B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecorationConditionComponentInDay.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x001259A8 File Offset: 0x00123BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92400, XrefRangeEnd = 92408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecorationConditionComponentInDay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorationConditionComponentInDay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationConditionComponentInDay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x00017D63 File Offset: 0x00015F63
		public DecorationConditionComponentInDay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x001259E4 File Offset: 0x00123BE4
		// (set) Token: 0x0600289E RID: 10398 RVA: 0x00017D6C File Offset: 0x00015F6C
		public unsafe Il2CppStructArray<int> decorationId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationConditionComponentInDay.NativeFieldInfoPtr_decorationId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationConditionComponentInDay.NativeFieldInfoPtr_decorationId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x00125A14 File Offset: 0x00123C14
		// (set) Token: 0x060028A0 RID: 10400 RVA: 0x00017D8B File Offset: 0x00015F8B
		public unsafe bool inverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationConditionComponentInDay.NativeFieldInfoPtr_inverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationConditionComponentInDay.NativeFieldInfoPtr_inverse)) = value;
			}
		}

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeFieldInfoPtr_decorationId;

		// Token: 0x04001AE0 RID: 6880
		private static readonly IntPtr NativeFieldInfoPtr_inverse;

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0;

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeMethodInfoPtr_Used_Private_Boolean_0;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
