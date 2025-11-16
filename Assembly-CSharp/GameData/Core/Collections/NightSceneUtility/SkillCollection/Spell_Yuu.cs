using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.GuestManagementUtility;
using NightScene.UI.EventUtility;
using TMPro;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000294 RID: 660
	public class Spell_Yuu : SpellBase
	{
		// Token: 0x0600538E RID: 21390 RVA: 0x001B9188 File Offset: 0x001B7388
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Yuu()
		{
			Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Yuu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr);
			Spell_Yuu.NativeFieldInfoPtr_YUU_BUFF_MARK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "YUU_BUFF_MARK");
			Spell_Yuu.NativeFieldInfoPtr_displayUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "displayUI");
			Spell_Yuu.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "negativeDuration");
			Spell_Yuu.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "positiveDuration");
			Spell_Yuu.NativeFieldInfoPtr_UIFieldIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "UIFieldIndex");
			Spell_Yuu.NativeFieldInfoPtr_UIOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "UIOffset");
			Spell_Yuu.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, 100680319);
			Spell_Yuu.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, 100680320);
			Spell_Yuu.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, 100680321);
			Spell_Yuu.NativeMethodInfoPtr_GetEffectDisplayer_Private_GameObject_GuestGroupController_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, 100680322);
			Spell_Yuu.NativeMethodInfoPtr_SetNum_Private_Void_GuestGroupController_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, 100680323);
			Spell_Yuu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, 100680324);
			Spell_Yuu.NativeMethodInfoPtr_Method_Internal_Static_String_Int32_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, 100680325);
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x001B92BC File Offset: 0x001B74BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209231, XrefRangeEnd = 209233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yuu.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x001B9300 File Offset: 0x001B7500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209233, XrefRangeEnd = 209238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yuu.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x001B935C File Offset: 0x001B755C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209238, XrefRangeEnd = 209244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yuu.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005392 RID: 21394 RVA: 0x001B93B8 File Offset: 0x001B75B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 209273, RefRangeEnd = 209275, XrefRangeStart = 209244, XrefRangeEnd = 209273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetEffectDisplayer(GuestGroupController guestGroup, out bool successNewSpawn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &successNewSpawn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.NativeMethodInfoPtr_GetEffectDisplayer_Private_GameObject_GuestGroupController_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x001B9418 File Offset: 0x001B7618
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209298, RefRangeEnd = 209301, XrefRangeStart = 209275, XrefRangeEnd = 209298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNum(GuestGroupController guestGroupController, GameObject targetDisplayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetDisplayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.NativeMethodInfoPtr_SetNum_Private_Void_GuestGroupController_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x001B946C File Offset: 0x001B766C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209301, XrefRangeEnd = 209302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Yuu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005395 RID: 21397 RVA: 0x001B94A8 File Offset: 0x001B76A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209302, XrefRangeEnd = 209306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_Int32_String_PDM_0(int currentTime, string buffDescription)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.NativeMethodInfoPtr_Method_Internal_Static_String_Int32_String_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x0002CE48 File Offset: 0x0002B048
		public Spell_Yuu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x06005397 RID: 21399 RVA: 0x001B94F4 File Offset: 0x001B76F4
		// (set) Token: 0x06005398 RID: 21400 RVA: 0x0002CE51 File Offset: 0x0002B051
		public unsafe static GuestBuffMarkModule.GuestBuffMark YUU_BUFF_MARK
		{
			get
			{
				GuestBuffMarkModule.GuestBuffMark result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Yuu.NativeFieldInfoPtr_YUU_BUFF_MARK, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Yuu.NativeFieldInfoPtr_YUU_BUFF_MARK, (void*)(&value));
			}
		}

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x06005399 RID: 21401 RVA: 0x001B9510 File Offset: 0x001B7710
		// (set) Token: 0x0600539A RID: 21402 RVA: 0x0002CE5F File Offset: 0x0002B05F
		public unsafe GameObject displayUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.NativeFieldInfoPtr_displayUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.NativeFieldInfoPtr_displayUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x0600539B RID: 21403 RVA: 0x001B9540 File Offset: 0x001B7740
		// (set) Token: 0x0600539C RID: 21404 RVA: 0x0002CE7E File Offset: 0x0002B07E
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x0600539D RID: 21405 RVA: 0x001B9568 File Offset: 0x001B7768
		// (set) Token: 0x0600539E RID: 21406 RVA: 0x0002CE99 File Offset: 0x0002B099
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x0600539F RID: 21407 RVA: 0x001B9590 File Offset: 0x001B7790
		// (set) Token: 0x060053A0 RID: 21408 RVA: 0x0002CEB4 File Offset: 0x0002B0B4
		public unsafe int UIFieldIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.NativeFieldInfoPtr_UIFieldIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.NativeFieldInfoPtr_UIFieldIndex)) = value;
			}
		}

		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x060053A1 RID: 21409 RVA: 0x001B95B8 File Offset: 0x001B77B8
		// (set) Token: 0x060053A2 RID: 21410 RVA: 0x0002CECF File Offset: 0x0002B0CF
		public unsafe float UIOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.NativeFieldInfoPtr_UIOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.NativeFieldInfoPtr_UIOffset)) = value;
			}
		}

		// Token: 0x04003836 RID: 14390
		private static readonly IntPtr NativeFieldInfoPtr_YUU_BUFF_MARK;

		// Token: 0x04003837 RID: 14391
		private static readonly IntPtr NativeFieldInfoPtr_displayUI;

		// Token: 0x04003838 RID: 14392
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x04003839 RID: 14393
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x0400383A RID: 14394
		private static readonly IntPtr NativeFieldInfoPtr_UIFieldIndex;

		// Token: 0x0400383B RID: 14395
		private static readonly IntPtr NativeFieldInfoPtr_UIOffset;

		// Token: 0x0400383C RID: 14396
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x0400383D RID: 14397
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400383E RID: 14398
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400383F RID: 14399
		private static readonly IntPtr NativeMethodInfoPtr_GetEffectDisplayer_Private_GameObject_GuestGroupController_byref_Boolean_0;

		// Token: 0x04003840 RID: 14400
		private static readonly IntPtr NativeMethodInfoPtr_SetNum_Private_Void_GuestGroupController_GameObject_0;

		// Token: 0x04003841 RID: 14401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003842 RID: 14402
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Int32_String_PDM_0;

		// Token: 0x02000C1C RID: 3100
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuu+<OnNegativeBuffExecute>d__7")]
		public sealed class _OnNegativeBuffExecute_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600E0D6 RID: 57558 RVA: 0x003645A0 File Offset: 0x003627A0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__7()
			{
				Il2CppClassPointerStore<Spell_Yuu._OnNegativeBuffExecute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "<OnNegativeBuffExecute>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuu._OnNegativeBuffExecute_d__7>.NativeClassPtr);
				Spell_Yuu._OnNegativeBuffExecute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu._OnNegativeBuffExecute_d__7>.NativeClassPtr, "<>1__state");
				Spell_Yuu._OnNegativeBuffExecute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu._OnNegativeBuffExecute_d__7>.NativeClassPtr, "<>2__current");
				Spell_Yuu._OnNegativeBuffExecute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu._OnNegativeBuffExecute_d__7>.NativeClassPtr, "<>4__this");
				Spell_Yuu._OnNegativeBuffExecute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu._OnNegativeBuffExecute_d__7>.NativeClassPtr, 100680326);
				Spell_Yuu._OnNegativeBuffExecute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu._OnNegativeBuffExecute_d__7>.NativeClassPtr, 100680327);
				Spell_Yuu._OnNegativeBuffExecute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu._OnNegativeBuffExecute_d__7>.NativeClassPtr, 100680328);
				Spell_Yuu._OnNegativeBuffExecute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu._OnNegativeBuffExecute_d__7>.NativeClassPtr, 100680329);
				Spell_Yuu._OnNegativeBuffExecute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu._OnNegativeBuffExecute_d__7>.NativeClassPtr, 100680330);
				Spell_Yuu._OnNegativeBuffExecute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu._OnNegativeBuffExecute_d__7>.NativeClassPtr, 100680331);
			}

			// Token: 0x0600E0D7 RID: 57559 RVA: 0x00364680 File Offset: 0x00362880
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuu._OnNegativeBuffExecute_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu._OnNegativeBuffExecute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0D8 RID: 57560 RVA: 0x003646C8 File Offset: 0x003628C8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu._OnNegativeBuffExecute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0D9 RID: 57561 RVA: 0x003646FC File Offset: 0x003628FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208820, XrefRangeEnd = 208825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu._OnNegativeBuffExecute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004909 RID: 18697
			// (get) Token: 0x0600E0DA RID: 57562 RVA: 0x00364738 File Offset: 0x00362938
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu._OnNegativeBuffExecute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E0DB RID: 57563 RVA: 0x00364778 File Offset: 0x00362978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208825, XrefRangeEnd = 208831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu._OnNegativeBuffExecute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700490A RID: 18698
			// (get) Token: 0x0600E0DC RID: 57564 RVA: 0x003647AC File Offset: 0x003629AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu._OnNegativeBuffExecute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E0DD RID: 57565 RVA: 0x00077F5A File Offset: 0x0007615A
			public _OnNegativeBuffExecute_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004906 RID: 18694
			// (get) Token: 0x0600E0DE RID: 57566 RVA: 0x003647EC File Offset: 0x003629EC
			// (set) Token: 0x0600E0DF RID: 57567 RVA: 0x00077F63 File Offset: 0x00076163
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu._OnNegativeBuffExecute_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu._OnNegativeBuffExecute_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004907 RID: 18695
			// (get) Token: 0x0600E0E0 RID: 57568 RVA: 0x00364814 File Offset: 0x00362A14
			// (set) Token: 0x0600E0E1 RID: 57569 RVA: 0x00077F7E File Offset: 0x0007617E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu._OnNegativeBuffExecute_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu._OnNegativeBuffExecute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004908 RID: 18696
			// (get) Token: 0x0600E0E2 RID: 57570 RVA: 0x00364844 File Offset: 0x00362A44
			// (set) Token: 0x0600E0E3 RID: 57571 RVA: 0x00077F9D File Offset: 0x0007619D
			public unsafe Spell_Yuu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu._OnNegativeBuffExecute_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu._OnNegativeBuffExecute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FD7 RID: 36823
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008FD8 RID: 36824
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008FD9 RID: 36825
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FDA RID: 36826
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008FDB RID: 36827
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FDC RID: 36828
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008FDD RID: 36829
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008FDE RID: 36830
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FDF RID: 36831
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C1D RID: 3101
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuu+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E0E4 RID: 57572 RVA: 0x00364874 File Offset: 0x00362A74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_0>.NativeClassPtr);
				Spell_Yuu.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				Spell_Yuu.__c__DisplayClass8_0.NativeFieldInfoPtr_onEndAllDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_0>.NativeClassPtr, "onEndAllDisplayer");
				Spell_Yuu.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_0>.NativeClassPtr, 100680332);
				Spell_Yuu.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_0>.NativeClassPtr, 100680333);
				Spell_Yuu.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_0>.NativeClassPtr, 100680334);
				Spell_Yuu.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_0>.NativeClassPtr, 100680335);
			}

			// Token: 0x0600E0E5 RID: 57573 RVA: 0x00364918 File Offset: 0x00362B18
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0E6 RID: 57574 RVA: 0x00364954 File Offset: 0x00362B54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208831, XrefRangeEnd = 208847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0E7 RID: 57575 RVA: 0x00364994 File Offset: 0x00362B94
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 208879, RefRangeEnd = 208880, XrefRangeStart = 208847, XrefRangeEnd = 208879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_0(GuestGroupController guestGroup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0E8 RID: 57576 RVA: 0x003649D8 File Offset: 0x00362BD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208880, XrefRangeEnd = 208890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0E9 RID: 57577 RVA: 0x00077FBC File Offset: 0x000761BC
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700490B RID: 18699
			// (get) Token: 0x0600E0EA RID: 57578 RVA: 0x00364A0C File Offset: 0x00362C0C
			// (set) Token: 0x0600E0EB RID: 57579 RVA: 0x00077FC5 File Offset: 0x000761C5
			public unsafe Spell_Yuu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700490C RID: 18700
			// (get) Token: 0x0600E0EC RID: 57580 RVA: 0x00364A3C File Offset: 0x00362C3C
			// (set) Token: 0x0600E0ED RID: 57581 RVA: 0x00077FE4 File Offset: 0x000761E4
			public unsafe Action onEndAllDisplayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_0.NativeFieldInfoPtr_onEndAllDisplayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_0.NativeFieldInfoPtr_onEndAllDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FE0 RID: 36832
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FE1 RID: 36833
			private static readonly IntPtr NativeFieldInfoPtr_onEndAllDisplayer;

			// Token: 0x04008FE2 RID: 36834
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FE3 RID: 36835
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_Int32_0;

			// Token: 0x04008FE4 RID: 36836
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_0;

			// Token: 0x04008FE5 RID: 36837
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000C1E RID: 3102
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuu+<>c__DisplayClass8_1")]
		public sealed class __c__DisplayClass8_1 : Il2CppSystem.Object
		{
			// Token: 0x0600E0EE RID: 57582 RVA: 0x00364A6C File Offset: 0x00362C6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_1()
			{
				Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "<>c__DisplayClass8_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_1>.NativeClassPtr);
				Spell_Yuu.__c__DisplayClass8_1.NativeFieldInfoPtr_effectDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_1>.NativeClassPtr, "effectDisplayer");
				Spell_Yuu.__c__DisplayClass8_1.NativeFieldInfoPtr_guestGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_1>.NativeClassPtr, "guestGroup");
				Spell_Yuu.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Yuu.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_1>.NativeClassPtr, 100680336);
				Spell_Yuu.__c__DisplayClass8_1.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_1>.NativeClassPtr, 100680337);
				Spell_Yuu.__c__DisplayClass8_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_1>.NativeClassPtr, 100680338);
			}

			// Token: 0x0600E0EF RID: 57583 RVA: 0x00364B10 File Offset: 0x00362D10
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0F0 RID: 57584 RVA: 0x00364B4C File Offset: 0x00362D4C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 208895, RefRangeEnd = 208896, XrefRangeStart = 208890, XrefRangeEnd = 208895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_0(GuestGroupController thisGuest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisGuest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass8_1.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0F1 RID: 57585 RVA: 0x00364B90 File Offset: 0x00362D90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208896, XrefRangeEnd = 208926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass8_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0F2 RID: 57586 RVA: 0x00078003 File Offset: 0x00076203
			public __c__DisplayClass8_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700490D RID: 18701
			// (get) Token: 0x0600E0F3 RID: 57587 RVA: 0x00364BC4 File Offset: 0x00362DC4
			// (set) Token: 0x0600E0F4 RID: 57588 RVA: 0x0007800C File Offset: 0x0007620C
			public unsafe GameObject effectDisplayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_1.NativeFieldInfoPtr_effectDisplayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_1.NativeFieldInfoPtr_effectDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700490E RID: 18702
			// (get) Token: 0x0600E0F5 RID: 57589 RVA: 0x00364BF4 File Offset: 0x00362DF4
			// (set) Token: 0x0600E0F6 RID: 57590 RVA: 0x0007802B File Offset: 0x0007622B
			public unsafe GuestGroupController guestGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_1.NativeFieldInfoPtr_guestGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_1.NativeFieldInfoPtr_guestGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700490F RID: 18703
			// (get) Token: 0x0600E0F7 RID: 57591 RVA: 0x00364C24 File Offset: 0x00362E24
			// (set) Token: 0x0600E0F8 RID: 57592 RVA: 0x0007804A File Offset: 0x0007624A
			public unsafe Spell_Yuu.__c__DisplayClass8_0 field_Public___c__DisplayClass8_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuu.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FE6 RID: 36838
			private static readonly IntPtr NativeFieldInfoPtr_effectDisplayer;

			// Token: 0x04008FE7 RID: 36839
			private static readonly IntPtr NativeFieldInfoPtr_guestGroup;

			// Token: 0x04008FE8 RID: 36840
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0;

			// Token: 0x04008FE9 RID: 36841
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FEA RID: 36842
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_0;

			// Token: 0x04008FEB RID: 36843
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000C1F RID: 3103
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuu+<>c__DisplayClass8_2")]
		public sealed class __c__DisplayClass8_2 : Il2CppSystem.Object
		{
			// Token: 0x0600E0F9 RID: 57593 RVA: 0x00364C54 File Offset: 0x00362E54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_2()
			{
				Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "<>c__DisplayClass8_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_2>.NativeClassPtr);
				Spell_Yuu.__c__DisplayClass8_2.NativeFieldInfoPtr_guestGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_2>.NativeClassPtr, "guestGroup");
				Spell_Yuu.__c__DisplayClass8_2.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_2>.NativeClassPtr, "CS$<>8__locals2");
				Spell_Yuu.__c__DisplayClass8_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_2>.NativeClassPtr, 100680339);
				Spell_Yuu.__c__DisplayClass8_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_2>.NativeClassPtr, 100680340);
				Spell_Yuu.__c__DisplayClass8_2.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_2>.NativeClassPtr, 100680341);
			}

			// Token: 0x0600E0FA RID: 57594 RVA: 0x00364CE4 File Offset: 0x00362EE4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass8_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0FB RID: 57595 RVA: 0x00364D20 File Offset: 0x00362F20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208926, XrefRangeEnd = 208938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass8_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0FC RID: 57596 RVA: 0x00364D54 File Offset: 0x00362F54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208938, XrefRangeEnd = 208968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController thisGuest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisGuest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass8_2.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0FD RID: 57597 RVA: 0x00078069 File Offset: 0x00076269
			public __c__DisplayClass8_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004910 RID: 18704
			// (get) Token: 0x0600E0FE RID: 57598 RVA: 0x00364D98 File Offset: 0x00362F98
			// (set) Token: 0x0600E0FF RID: 57599 RVA: 0x00078072 File Offset: 0x00076272
			public unsafe GuestGroupController guestGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_2.NativeFieldInfoPtr_guestGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_2.NativeFieldInfoPtr_guestGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004911 RID: 18705
			// (get) Token: 0x0600E100 RID: 57600 RVA: 0x00364DC8 File Offset: 0x00362FC8
			// (set) Token: 0x0600E101 RID: 57601 RVA: 0x00078091 File Offset: 0x00076291
			public unsafe Spell_Yuu.__c__DisplayClass8_0 field_Public___c__DisplayClass8_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_2.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuu.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_2.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FEC RID: 36844
			private static readonly IntPtr NativeFieldInfoPtr_guestGroup;

			// Token: 0x04008FED RID: 36845
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0;

			// Token: 0x04008FEE RID: 36846
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FEF RID: 36847
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Void_0;

			// Token: 0x04008FF0 RID: 36848
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;
		}

		// Token: 0x02000C20 RID: 3104
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuu+<>c__DisplayClass8_3")]
		public sealed class __c__DisplayClass8_3 : Il2CppSystem.Object
		{
			// Token: 0x0600E102 RID: 57602 RVA: 0x00364DF8 File Offset: 0x00362FF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_3()
			{
				Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "<>c__DisplayClass8_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_3>.NativeClassPtr);
				Spell_Yuu.__c__DisplayClass8_3.NativeFieldInfoPtr_effectDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_3>.NativeClassPtr, "effectDisplayer");
				Spell_Yuu.__c__DisplayClass8_3.NativeFieldInfoPtr_field_Public___c__DisplayClass8_2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_3>.NativeClassPtr, "CS$<>8__locals3");
				Spell_Yuu.__c__DisplayClass8_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_3>.NativeClassPtr, 100680342);
				Spell_Yuu.__c__DisplayClass8_3.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_3>.NativeClassPtr, 100680343);
				Spell_Yuu.__c__DisplayClass8_3.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_3>.NativeClassPtr, 100680344);
			}

			// Token: 0x0600E103 RID: 57603 RVA: 0x00364E88 File Offset: 0x00363088
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass8_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass8_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E104 RID: 57604 RVA: 0x00364EC4 File Offset: 0x003630C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208968, XrefRangeEnd = 208973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController orderedGuest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderedGuest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass8_3.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E105 RID: 57605 RVA: 0x00364F08 File Offset: 0x00363108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208973, XrefRangeEnd = 208989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass8_3.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E106 RID: 57606 RVA: 0x000780B0 File Offset: 0x000762B0
			public __c__DisplayClass8_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004912 RID: 18706
			// (get) Token: 0x0600E107 RID: 57607 RVA: 0x00364F3C File Offset: 0x0036313C
			// (set) Token: 0x0600E108 RID: 57608 RVA: 0x000780B9 File Offset: 0x000762B9
			public unsafe GameObject effectDisplayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_3.NativeFieldInfoPtr_effectDisplayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_3.NativeFieldInfoPtr_effectDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004913 RID: 18707
			// (get) Token: 0x0600E109 RID: 57609 RVA: 0x00364F6C File Offset: 0x0036316C
			// (set) Token: 0x0600E10A RID: 57610 RVA: 0x000780D8 File Offset: 0x000762D8
			public unsafe Spell_Yuu.__c__DisplayClass8_2 field_Public___c__DisplayClass8_2_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_3.NativeFieldInfoPtr_field_Public___c__DisplayClass8_2_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuu.__c__DisplayClass8_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass8_3.NativeFieldInfoPtr_field_Public___c__DisplayClass8_2_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FF1 RID: 36849
			private static readonly IntPtr NativeFieldInfoPtr_effectDisplayer;

			// Token: 0x04008FF2 RID: 36850
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass8_2_0;

			// Token: 0x04008FF3 RID: 36851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FF4 RID: 36852
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;

			// Token: 0x04008FF5 RID: 36853
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000C21 RID: 3105
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuu+<OnPositiveBuffExecute>d__8")]
		public sealed class _OnPositiveBuffExecute_d__8 : Il2CppSystem.Object
		{
			// Token: 0x0600E10B RID: 57611 RVA: 0x00364F9C File Offset: 0x0036319C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__8()
			{
				Il2CppClassPointerStore<Spell_Yuu._OnPositiveBuffExecute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "<OnPositiveBuffExecute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuu._OnPositiveBuffExecute_d__8>.NativeClassPtr);
				Spell_Yuu._OnPositiveBuffExecute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu._OnPositiveBuffExecute_d__8>.NativeClassPtr, "<>1__state");
				Spell_Yuu._OnPositiveBuffExecute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu._OnPositiveBuffExecute_d__8>.NativeClassPtr, "<>2__current");
				Spell_Yuu._OnPositiveBuffExecute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu._OnPositiveBuffExecute_d__8>.NativeClassPtr, "<>4__this");
				Spell_Yuu._OnPositiveBuffExecute_d__8.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu._OnPositiveBuffExecute_d__8>.NativeClassPtr, "spellExecutionContext");
				Spell_Yuu._OnPositiveBuffExecute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu._OnPositiveBuffExecute_d__8>.NativeClassPtr, 100680345);
				Spell_Yuu._OnPositiveBuffExecute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu._OnPositiveBuffExecute_d__8>.NativeClassPtr, 100680346);
				Spell_Yuu._OnPositiveBuffExecute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu._OnPositiveBuffExecute_d__8>.NativeClassPtr, 100680347);
				Spell_Yuu._OnPositiveBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu._OnPositiveBuffExecute_d__8>.NativeClassPtr, 100680348);
				Spell_Yuu._OnPositiveBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu._OnPositiveBuffExecute_d__8>.NativeClassPtr, 100680349);
				Spell_Yuu._OnPositiveBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu._OnPositiveBuffExecute_d__8>.NativeClassPtr, 100680350);
			}

			// Token: 0x0600E10C RID: 57612 RVA: 0x00365090 File Offset: 0x00363290
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__8(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuu._OnPositiveBuffExecute_d__8>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu._OnPositiveBuffExecute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E10D RID: 57613 RVA: 0x003650D8 File Offset: 0x003632D8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu._OnPositiveBuffExecute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E10E RID: 57614 RVA: 0x0036510C File Offset: 0x0036330C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208989, XrefRangeEnd = 209068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu._OnPositiveBuffExecute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004918 RID: 18712
			// (get) Token: 0x0600E10F RID: 57615 RVA: 0x00365148 File Offset: 0x00363348
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu._OnPositiveBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E110 RID: 57616 RVA: 0x00365188 File Offset: 0x00363388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209068, XrefRangeEnd = 209074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu._OnPositiveBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004919 RID: 18713
			// (get) Token: 0x0600E111 RID: 57617 RVA: 0x003651BC File Offset: 0x003633BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu._OnPositiveBuffExecute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E112 RID: 57618 RVA: 0x000780F7 File Offset: 0x000762F7
			public _OnPositiveBuffExecute_d__8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004914 RID: 18708
			// (get) Token: 0x0600E113 RID: 57619 RVA: 0x003651FC File Offset: 0x003633FC
			// (set) Token: 0x0600E114 RID: 57620 RVA: 0x00078100 File Offset: 0x00076300
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu._OnPositiveBuffExecute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu._OnPositiveBuffExecute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004915 RID: 18709
			// (get) Token: 0x0600E115 RID: 57621 RVA: 0x00365224 File Offset: 0x00363424
			// (set) Token: 0x0600E116 RID: 57622 RVA: 0x0007811B File Offset: 0x0007631B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu._OnPositiveBuffExecute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu._OnPositiveBuffExecute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004916 RID: 18710
			// (get) Token: 0x0600E117 RID: 57623 RVA: 0x00365254 File Offset: 0x00363454
			// (set) Token: 0x0600E118 RID: 57624 RVA: 0x0007813A File Offset: 0x0007633A
			public unsafe Spell_Yuu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu._OnPositiveBuffExecute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu._OnPositiveBuffExecute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004917 RID: 18711
			// (get) Token: 0x0600E119 RID: 57625 RVA: 0x00365284 File Offset: 0x00363484
			// (set) Token: 0x0600E11A RID: 57626 RVA: 0x00078159 File Offset: 0x00076359
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu._OnPositiveBuffExecute_d__8.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu._OnPositiveBuffExecute_d__8.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FF6 RID: 36854
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008FF7 RID: 36855
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008FF8 RID: 36856
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FF9 RID: 36857
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008FFA RID: 36858
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008FFB RID: 36859
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FFC RID: 36860
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008FFD RID: 36861
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008FFE RID: 36862
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FFF RID: 36863
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C22 RID: 3106
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuu+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E11B RID: 57627 RVA: 0x003652B4 File Offset: 0x003634B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass9_0>.NativeClassPtr);
				Spell_Yuu.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				Spell_Yuu.__c__DisplayClass9_0.NativeFieldInfoPtr_guestGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass9_0>.NativeClassPtr, "guestGroup");
				Spell_Yuu.__c__DisplayClass9_0.NativeFieldInfoPtr_effectDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass9_0>.NativeClassPtr, "effectDisplayer");
				Spell_Yuu.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass9_0>.NativeClassPtr, 100680351);
				Spell_Yuu.__c__DisplayClass9_0.NativeMethodInfoPtr__GetEffectDisplayer_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass9_0>.NativeClassPtr, 100680352);
			}

			// Token: 0x0600E11C RID: 57628 RVA: 0x00365344 File Offset: 0x00363544
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E11D RID: 57629 RVA: 0x00365380 File Offset: 0x00363580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209074, XrefRangeEnd = 209093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetEffectDisplayer_b__0(GameObject y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass9_0.NativeMethodInfoPtr__GetEffectDisplayer_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E11E RID: 57630 RVA: 0x00078178 File Offset: 0x00076378
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700491A RID: 18714
			// (get) Token: 0x0600E11F RID: 57631 RVA: 0x003653C4 File Offset: 0x003635C4
			// (set) Token: 0x0600E120 RID: 57632 RVA: 0x00078181 File Offset: 0x00076381
			public unsafe Spell_Yuu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700491B RID: 18715
			// (get) Token: 0x0600E121 RID: 57633 RVA: 0x003653F4 File Offset: 0x003635F4
			// (set) Token: 0x0600E122 RID: 57634 RVA: 0x000781A0 File Offset: 0x000763A0
			public unsafe GuestGroupController guestGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass9_0.NativeFieldInfoPtr_guestGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass9_0.NativeFieldInfoPtr_guestGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700491C RID: 18716
			// (get) Token: 0x0600E123 RID: 57635 RVA: 0x00365424 File Offset: 0x00363624
			// (set) Token: 0x0600E124 RID: 57636 RVA: 0x000781BF File Offset: 0x000763BF
			public unsafe GameObject effectDisplayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass9_0.NativeFieldInfoPtr_effectDisplayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass9_0.NativeFieldInfoPtr_effectDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009000 RID: 36864
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009001 RID: 36865
			private static readonly IntPtr NativeFieldInfoPtr_guestGroup;

			// Token: 0x04009002 RID: 36866
			private static readonly IntPtr NativeFieldInfoPtr_effectDisplayer;

			// Token: 0x04009003 RID: 36867
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009004 RID: 36868
			private static readonly IntPtr NativeMethodInfoPtr__GetEffectDisplayer_b__0_Internal_Void_GameObject_0;
		}

		// Token: 0x02000C23 RID: 3107
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuu+<>c__DisplayClass9_1")]
		public sealed class __c__DisplayClass9_1 : Il2CppSystem.Object
		{
			// Token: 0x0600E125 RID: 57637 RVA: 0x00365454 File Offset: 0x00363654
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_1()
			{
				Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass9_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "<>c__DisplayClass9_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass9_1>.NativeClassPtr);
				Spell_Yuu.__c__DisplayClass9_1.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass9_1>.NativeClassPtr, "y");
				Spell_Yuu.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass9_1>.NativeClassPtr, 100680353);
				Spell_Yuu.__c__DisplayClass9_1.NativeMethodInfoPtr__GetEffectDisplayer_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass9_1>.NativeClassPtr, 100680354);
			}

			// Token: 0x0600E126 RID: 57638 RVA: 0x003654BC File Offset: 0x003636BC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass9_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E127 RID: 57639 RVA: 0x003654F8 File Offset: 0x003636F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209093, XrefRangeEnd = 209189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetEffectDisplayer_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass9_1.NativeMethodInfoPtr__GetEffectDisplayer_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E128 RID: 57640 RVA: 0x000781DE File Offset: 0x000763DE
			public __c__DisplayClass9_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700491D RID: 18717
			// (get) Token: 0x0600E129 RID: 57641 RVA: 0x0036552C File Offset: 0x0036372C
			// (set) Token: 0x0600E12A RID: 57642 RVA: 0x000781E7 File Offset: 0x000763E7
			public unsafe GameObject y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass9_1.NativeFieldInfoPtr_y);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass9_1.NativeFieldInfoPtr_y), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009005 RID: 36869
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04009006 RID: 36870
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009007 RID: 36871
			private static readonly IntPtr NativeMethodInfoPtr__GetEffectDisplayer_b__2_Internal_Void_0;
		}

		// Token: 0x02000C24 RID: 3108
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuu+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E12B RID: 57643 RVA: 0x0036555C File Offset: 0x0036375C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Yuu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuu.__c>.NativeClassPtr);
				Spell_Yuu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c>.NativeClassPtr, "<>9");
				Spell_Yuu.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c>.NativeClassPtr, "<>9__9_1");
				Spell_Yuu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c>.NativeClassPtr, 100680356);
				Spell_Yuu.__c.NativeMethodInfoPtr__GetEffectDisplayer_b__9_1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c>.NativeClassPtr, 100680357);
			}

			// Token: 0x0600E12C RID: 57644 RVA: 0x003655D8 File Offset: 0x003637D8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuu.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E12D RID: 57645 RVA: 0x00365614 File Offset: 0x00363814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209189, XrefRangeEnd = 209207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetEffectDisplayer_b__9_1(GameObject y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c.NativeMethodInfoPtr__GetEffectDisplayer_b__9_1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E12E RID: 57646 RVA: 0x00078206 File Offset: 0x00076406
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700491E RID: 18718
			// (get) Token: 0x0600E12F RID: 57647 RVA: 0x00365658 File Offset: 0x00363858
			// (set) Token: 0x0600E130 RID: 57648 RVA: 0x0007820F File Offset: 0x0007640F
			public unsafe static Spell_Yuu.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuu.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yuu.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuu.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700491F RID: 18719
			// (get) Token: 0x0600E131 RID: 57649 RVA: 0x00365680 File Offset: 0x00363880
			// (set) Token: 0x0600E132 RID: 57650 RVA: 0x00078221 File Offset: 0x00076421
			public unsafe static Action<GameObject> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yuu.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yuu.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009008 RID: 36872
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009009 RID: 36873
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x0400900A RID: 36874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400900B RID: 36875
			private static readonly IntPtr NativeMethodInfoPtr__GetEffectDisplayer_b__9_1_Internal_Void_GameObject_0;
		}

		// Token: 0x02000C25 RID: 3109
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yuu+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E133 RID: 57651 RVA: 0x003656A8 File Offset: 0x003638A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yuu>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass10_0>.NativeClassPtr);
				Spell_Yuu.__c__DisplayClass10_0.NativeFieldInfoPtr_guestGroupController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass10_0>.NativeClassPtr, "guestGroupController");
				Spell_Yuu.__c__DisplayClass10_0.NativeFieldInfoPtr_remainingMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass10_0>.NativeClassPtr, "remainingMoney");
				Spell_Yuu.__c__DisplayClass10_0.NativeFieldInfoPtr_remainingOrderChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass10_0>.NativeClassPtr, "remainingOrderChance");
				Spell_Yuu.__c__DisplayClass10_0.NativeFieldInfoPtr_orderChanceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass10_0>.NativeClassPtr, "orderChanceMax");
				Spell_Yuu.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass10_0>.NativeClassPtr, 100680358);
				Spell_Yuu.__c__DisplayClass10_0.NativeMethodInfoPtr__SetNum_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass10_0>.NativeClassPtr, 100680359);
				Spell_Yuu.__c__DisplayClass10_0.NativeMethodInfoPtr__SetNum_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass10_0>.NativeClassPtr, 100680360);
			}

			// Token: 0x0600E134 RID: 57652 RVA: 0x00365760 File Offset: 0x00363960
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yuu.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E135 RID: 57653 RVA: 0x0036579C File Offset: 0x0036399C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209207, XrefRangeEnd = 209222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetNum_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass10_0.NativeMethodInfoPtr__SetNum_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E136 RID: 57654 RVA: 0x003657E0 File Offset: 0x003639E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209222, XrefRangeEnd = 209231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetNum_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yuu.__c__DisplayClass10_0.NativeMethodInfoPtr__SetNum_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E137 RID: 57655 RVA: 0x00078233 File Offset: 0x00076433
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004920 RID: 18720
			// (get) Token: 0x0600E138 RID: 57656 RVA: 0x00365824 File Offset: 0x00363A24
			// (set) Token: 0x0600E139 RID: 57657 RVA: 0x0007823C File Offset: 0x0007643C
			public unsafe GuestGroupController guestGroupController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass10_0.NativeFieldInfoPtr_guestGroupController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass10_0.NativeFieldInfoPtr_guestGroupController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004921 RID: 18721
			// (get) Token: 0x0600E13A RID: 57658 RVA: 0x00365854 File Offset: 0x00363A54
			// (set) Token: 0x0600E13B RID: 57659 RVA: 0x0007825B File Offset: 0x0007645B
			public unsafe int remainingMoney
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass10_0.NativeFieldInfoPtr_remainingMoney);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass10_0.NativeFieldInfoPtr_remainingMoney)) = value;
				}
			}

			// Token: 0x17004922 RID: 18722
			// (get) Token: 0x0600E13C RID: 57660 RVA: 0x0036587C File Offset: 0x00363A7C
			// (set) Token: 0x0600E13D RID: 57661 RVA: 0x00078276 File Offset: 0x00076476
			public unsafe int remainingOrderChance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass10_0.NativeFieldInfoPtr_remainingOrderChance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass10_0.NativeFieldInfoPtr_remainingOrderChance)) = value;
				}
			}

			// Token: 0x17004923 RID: 18723
			// (get) Token: 0x0600E13E RID: 57662 RVA: 0x003658A4 File Offset: 0x00363AA4
			// (set) Token: 0x0600E13F RID: 57663 RVA: 0x00078291 File Offset: 0x00076491
			public unsafe int orderChanceMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass10_0.NativeFieldInfoPtr_orderChanceMax);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yuu.__c__DisplayClass10_0.NativeFieldInfoPtr_orderChanceMax)) = value;
				}
			}

			// Token: 0x0400900C RID: 36876
			private static readonly IntPtr NativeFieldInfoPtr_guestGroupController;

			// Token: 0x0400900D RID: 36877
			private static readonly IntPtr NativeFieldInfoPtr_remainingMoney;

			// Token: 0x0400900E RID: 36878
			private static readonly IntPtr NativeFieldInfoPtr_remainingOrderChance;

			// Token: 0x0400900F RID: 36879
			private static readonly IntPtr NativeFieldInfoPtr_orderChanceMax;

			// Token: 0x04009010 RID: 36880
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009011 RID: 36881
			private static readonly IntPtr NativeMethodInfoPtr__SetNum_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04009012 RID: 36882
			private static readonly IntPtr NativeMethodInfoPtr__SetNum_b__1_Internal_Void_TextMeshProUGUI_0;
		}
	}
}
