using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200018C RID: 396
	public class ThreeFairiesBehaviourComponent : MultipleInteractionsBehaviourComponent
	{
		// Token: 0x06002AF3 RID: 10995 RVA: 0x0012D184 File Offset: 0x0012B384
		// Note: this type is marked as 'beforefieldinit'.
		static ThreeFairiesBehaviourComponent()
		{
			Il2CppClassPointerStore<ThreeFairiesBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "ThreeFairiesBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreeFairiesBehaviourComponent>.NativeClassPtr);
			ThreeFairiesBehaviourComponent.NativeFieldInfoPtr_THREE_FAIRIES_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreeFairiesBehaviourComponent>.NativeClassPtr, "THREE_FAIRIES_ID");
			ThreeFairiesBehaviourComponent.NativeFieldInfoPtr_DIALOG_MAXINDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreeFairiesBehaviourComponent>.NativeClassPtr, "DIALOG_MAXINDEX");
			ThreeFairiesBehaviourComponent.NativeFieldInfoPtr_firstConversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreeFairiesBehaviourComponent>.NativeClassPtr, "firstConversation");
			ThreeFairiesBehaviourComponent.NativeFieldInfoPtr_normalConversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreeFairiesBehaviourComponent>.NativeClassPtr, "normalConversation");
			ThreeFairiesBehaviourComponent.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreeFairiesBehaviourComponent>.NativeClassPtr, 100670758);
			ThreeFairiesBehaviourComponent.NativeMethodInfoPtr_Interact_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreeFairiesBehaviourComponent>.NativeClassPtr, 100670759);
			ThreeFairiesBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreeFairiesBehaviourComponent>.NativeClassPtr, 100670760);
			ThreeFairiesBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreeFairiesBehaviourComponent>.NativeClassPtr, 100670761);
			ThreeFairiesBehaviourComponent.NativeMethodInfoPtr__Start_b__4_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreeFairiesBehaviourComponent>.NativeClassPtr, 100670762);
			ThreeFairiesBehaviourComponent.NativeMethodInfoPtr__Start_b__4_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreeFairiesBehaviourComponent>.NativeClassPtr, 100670763);
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x0012D27C File Offset: 0x0012B47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95879, XrefRangeEnd = 95902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThreeFairiesBehaviourComponent.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x0012D2B8 File Offset: 0x0012B4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95902, XrefRangeEnd = 95906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interact()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThreeFairiesBehaviourComponent.NativeMethodInfoPtr_Interact_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x0012D2F4 File Offset: 0x0012B4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95906, XrefRangeEnd = 95913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThreeFairiesBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x0012D330 File Offset: 0x0012B530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreeFairiesBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreeFairiesBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreeFairiesBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x0012D36C File Offset: 0x0012B56C
		[CallerCount(0)]
		public unsafe void _Start_b__4_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreeFairiesBehaviourComponent.NativeMethodInfoPtr__Start_b__4_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x0012D3A0 File Offset: 0x0012B5A0
		[CallerCount(0)]
		public unsafe void _Start_b__4_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreeFairiesBehaviourComponent.NativeMethodInfoPtr__Start_b__4_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x0001909D File Offset: 0x0001729D
		public ThreeFairiesBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06002AFB RID: 11003 RVA: 0x0012D3D4 File Offset: 0x0012B5D4
		// (set) Token: 0x06002AFC RID: 11004 RVA: 0x000190A6 File Offset: 0x000172A6
		public unsafe static string THREE_FAIRIES_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreeFairiesBehaviourComponent.NativeFieldInfoPtr_THREE_FAIRIES_ID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreeFairiesBehaviourComponent.NativeFieldInfoPtr_THREE_FAIRIES_ID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x0012D3F4 File Offset: 0x0012B5F4
		// (set) Token: 0x06002AFE RID: 11006 RVA: 0x000190B8 File Offset: 0x000172B8
		public unsafe static int DIALOG_MAXINDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ThreeFairiesBehaviourComponent.NativeFieldInfoPtr_DIALOG_MAXINDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreeFairiesBehaviourComponent.NativeFieldInfoPtr_DIALOG_MAXINDEX, (void*)(&value));
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x0012D410 File Offset: 0x0012B610
		// (set) Token: 0x06002B00 RID: 11008 RVA: 0x000190C6 File Offset: 0x000172C6
		public unsafe DialogPackage firstConversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreeFairiesBehaviourComponent.NativeFieldInfoPtr_firstConversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreeFairiesBehaviourComponent.NativeFieldInfoPtr_firstConversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x0012D440 File Offset: 0x0012B640
		// (set) Token: 0x06002B02 RID: 11010 RVA: 0x000190E5 File Offset: 0x000172E5
		public unsafe DialogPackage normalConversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreeFairiesBehaviourComponent.NativeFieldInfoPtr_normalConversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreeFairiesBehaviourComponent.NativeFieldInfoPtr_normalConversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeFieldInfoPtr_THREE_FAIRIES_ID;

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeFieldInfoPtr_DIALOG_MAXINDEX;

		// Token: 0x04001C64 RID: 7268
		private static readonly IntPtr NativeFieldInfoPtr_firstConversation;

		// Token: 0x04001C65 RID: 7269
		private static readonly IntPtr NativeFieldInfoPtr_normalConversation;

		// Token: 0x04001C66 RID: 7270
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001C67 RID: 7271
		private static readonly IntPtr NativeMethodInfoPtr_Interact_Protected_Virtual_Void_0;

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C6A RID: 7274
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__4_0_Private_Void_0;

		// Token: 0x04001C6B RID: 7275
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__4_1_Private_Void_0;
	}
}
