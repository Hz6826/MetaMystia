using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001EF RID: 495
	public class NS_MGuest_PlayCustomDialog_Behaviuor : ExtendedPlayableBehaviour
	{
		// Token: 0x06003CBF RID: 15551 RVA: 0x0016CC04 File Offset: 0x0016AE04
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_PlayCustomDialog_Behaviuor()
		{
			Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog_Behaviuor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_PlayCustomDialog_Behaviuor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog_Behaviuor>.NativeClassPtr);
			NS_MGuest_PlayCustomDialog_Behaviuor.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog_Behaviuor>.NativeClassPtr, "label");
			NS_MGuest_PlayCustomDialog_Behaviuor.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog_Behaviuor>.NativeClassPtr, "title");
			NS_MGuest_PlayCustomDialog_Behaviuor.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog_Behaviuor>.NativeClassPtr, "duration");
			NS_MGuest_PlayCustomDialog_Behaviuor.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog_Behaviuor>.NativeClassPtr, "shouldWaitForFinish");
			NS_MGuest_PlayCustomDialog_Behaviuor.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog_Behaviuor>.NativeClassPtr, 100674520);
			NS_MGuest_PlayCustomDialog_Behaviuor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog_Behaviuor>.NativeClassPtr, 100674521);
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x0016CCAC File Offset: 0x0016AEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136966, XrefRangeEnd = 136973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_PlayCustomDialog_Behaviuor.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x0016CCE8 File Offset: 0x0016AEE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_PlayCustomDialog_Behaviuor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog_Behaviuor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_PlayCustomDialog_Behaviuor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x000220EB File Offset: 0x000202EB
		public NS_MGuest_PlayCustomDialog_Behaviuor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x06003CC3 RID: 15555 RVA: 0x0016CD24 File Offset: 0x0016AF24
		// (set) Token: 0x06003CC4 RID: 15556 RVA: 0x000220F4 File Offset: 0x000202F4
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog_Behaviuor.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog_Behaviuor.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x0016CD4C File Offset: 0x0016AF4C
		// (set) Token: 0x06003CC6 RID: 15558 RVA: 0x00022113 File Offset: 0x00020313
		public unsafe string title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog_Behaviuor.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog_Behaviuor.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x0016CD74 File Offset: 0x0016AF74
		// (set) Token: 0x06003CC8 RID: 15560 RVA: 0x00022132 File Offset: 0x00020332
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog_Behaviuor.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog_Behaviuor.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x0016CD9C File Offset: 0x0016AF9C
		// (set) Token: 0x06003CCA RID: 15562 RVA: 0x0002214D File Offset: 0x0002034D
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog_Behaviuor.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog_Behaviuor.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x040028B4 RID: 10420
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040028B5 RID: 10421
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x040028B6 RID: 10422
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x040028B7 RID: 10423
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x040028B8 RID: 10424
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028B9 RID: 10425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
