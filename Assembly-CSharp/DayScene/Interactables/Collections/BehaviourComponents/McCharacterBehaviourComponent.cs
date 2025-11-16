using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000186 RID: 390
	public class McCharacterBehaviourComponent : MultipleInteractionsBehaviourComponent
	{
		// Token: 0x06002A89 RID: 10889 RVA: 0x0012BD50 File Offset: 0x00129F50
		// Note: this type is marked as 'beforefieldinit'.
		static McCharacterBehaviourComponent()
		{
			Il2CppClassPointerStore<McCharacterBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "McCharacterBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<McCharacterBehaviourComponent>.NativeClassPtr);
			McCharacterBehaviourComponent.NativeFieldInfoPtr_MC_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<McCharacterBehaviourComponent>.NativeClassPtr, "MC_ID");
			McCharacterBehaviourComponent.NativeFieldInfoPtr_DIALOG_MAXINDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<McCharacterBehaviourComponent>.NativeClassPtr, "DIALOG_MAXINDEX");
			McCharacterBehaviourComponent.NativeFieldInfoPtr_firstConversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<McCharacterBehaviourComponent>.NativeClassPtr, "firstConversation");
			McCharacterBehaviourComponent.NativeFieldInfoPtr_normalConversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<McCharacterBehaviourComponent>.NativeClassPtr, "normalConversation");
			McCharacterBehaviourComponent.NativeFieldInfoPtr_errorConversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<McCharacterBehaviourComponent>.NativeClassPtr, "errorConversation");
			McCharacterBehaviourComponent.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<McCharacterBehaviourComponent>.NativeClassPtr, 100670698);
			McCharacterBehaviourComponent.NativeMethodInfoPtr_Interact_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<McCharacterBehaviourComponent>.NativeClassPtr, 100670699);
			McCharacterBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<McCharacterBehaviourComponent>.NativeClassPtr, 100670700);
			McCharacterBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<McCharacterBehaviourComponent>.NativeClassPtr, 100670701);
			McCharacterBehaviourComponent.NativeMethodInfoPtr__Start_b__5_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<McCharacterBehaviourComponent>.NativeClassPtr, 100670702);
			McCharacterBehaviourComponent.NativeMethodInfoPtr__Start_b__5_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<McCharacterBehaviourComponent>.NativeClassPtr, 100670703);
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x0012BE5C File Offset: 0x0012A05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95365, XrefRangeEnd = 95388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), McCharacterBehaviourComponent.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x0012BE98 File Offset: 0x0012A098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95388, XrefRangeEnd = 95392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interact()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), McCharacterBehaviourComponent.NativeMethodInfoPtr_Interact_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x0012BED4 File Offset: 0x0012A0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95392, XrefRangeEnd = 95400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), McCharacterBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x0012BF10 File Offset: 0x0012A110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95400, XrefRangeEnd = 95401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe McCharacterBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<McCharacterBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(McCharacterBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x0012BF4C File Offset: 0x0012A14C
		[CallerCount(0)]
		public unsafe void _Start_b__5_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(McCharacterBehaviourComponent.NativeMethodInfoPtr__Start_b__5_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x0012BF80 File Offset: 0x0012A180
		[CallerCount(0)]
		public unsafe void _Start_b__5_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(McCharacterBehaviourComponent.NativeMethodInfoPtr__Start_b__5_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x00018D73 File Offset: 0x00016F73
		public McCharacterBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06002A91 RID: 10897 RVA: 0x0012BFB4 File Offset: 0x0012A1B4
		// (set) Token: 0x06002A92 RID: 10898 RVA: 0x00018D7C File Offset: 0x00016F7C
		public unsafe static string MC_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(McCharacterBehaviourComponent.NativeFieldInfoPtr_MC_ID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(McCharacterBehaviourComponent.NativeFieldInfoPtr_MC_ID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x0012BFD4 File Offset: 0x0012A1D4
		// (set) Token: 0x06002A94 RID: 10900 RVA: 0x00018D8E File Offset: 0x00016F8E
		public unsafe static int DIALOG_MAXINDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(McCharacterBehaviourComponent.NativeFieldInfoPtr_DIALOG_MAXINDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(McCharacterBehaviourComponent.NativeFieldInfoPtr_DIALOG_MAXINDEX, (void*)(&value));
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x0012BFF0 File Offset: 0x0012A1F0
		// (set) Token: 0x06002A96 RID: 10902 RVA: 0x00018D9C File Offset: 0x00016F9C
		public unsafe DialogPackage firstConversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(McCharacterBehaviourComponent.NativeFieldInfoPtr_firstConversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(McCharacterBehaviourComponent.NativeFieldInfoPtr_firstConversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06002A97 RID: 10903 RVA: 0x0012C020 File Offset: 0x0012A220
		// (set) Token: 0x06002A98 RID: 10904 RVA: 0x00018DBB File Offset: 0x00016FBB
		public unsafe DialogPackage normalConversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(McCharacterBehaviourComponent.NativeFieldInfoPtr_normalConversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(McCharacterBehaviourComponent.NativeFieldInfoPtr_normalConversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x0012C050 File Offset: 0x0012A250
		// (set) Token: 0x06002A9A RID: 10906 RVA: 0x00018DDA File Offset: 0x00016FDA
		public unsafe DialogPackage errorConversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(McCharacterBehaviourComponent.NativeFieldInfoPtr_errorConversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(McCharacterBehaviourComponent.NativeFieldInfoPtr_errorConversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeFieldInfoPtr_MC_ID;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeFieldInfoPtr_DIALOG_MAXINDEX;

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeFieldInfoPtr_firstConversation;

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeFieldInfoPtr_normalConversation;

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeFieldInfoPtr_errorConversation;

		// Token: 0x04001C19 RID: 7193
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001C1A RID: 7194
		private static readonly IntPtr NativeMethodInfoPtr_Interact_Protected_Virtual_Void_0;

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__5_0_Private_Void_0;

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__5_1_Private_Void_0;
	}
}
